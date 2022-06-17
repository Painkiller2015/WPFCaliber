using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using WPFCaliber.Value;
using System.Collections.Generic;
using System.Diagnostics;

namespace Caliber
{
    public class QuartesLevels 
    {
        public Quartest QuartesLevel { get; }
        public QuartesLevels()
        {
            var parseQuarttesLevel = new JsonResourseQuartestLevelParse();
            parseQuarttesLevel.QuartestParse();
            QuartesLevel = parseQuarttesLevel.QuartestValue;
        }
    }
    public class JsonResourseQuartestLevelParse
    {
        public ResourseValue? ResourseValue { get; private set; }
        public Quartest? QuartestValue { get; private set; }
        public List<UpgradeNumeric>? LevelValue { get; private set; }
        private string? _pathFile;
        public async void ResourseParse()
        {
            _pathFile = SysConfig.GetLogPath();
            string[] contains =
            {
                "https://login.playcaliber.com/v1/account/close_loot_box",
                "https://login.playcaliber.com/v1/account/update"
            };

            string row = await SearchRow(contains);
            row = ResourseParseSubstring(row);
            ResourseValue = JsonConvert.DeserializeObject<ResourseValue>(row);
        }
        public async void QuartestParse()
        {
            _pathFile = SysConfig.GetLogPath();
            string[] contains = { "CurrentResearch" };
            string row = await SearchRow(contains);

            string? reserch = QuartestResearch(row);

            row = QuartestParseSubstring(row);
            QuartestValue = JsonConvert.DeserializeObject<Quartest>(row);

            if (reserch != null)
            {
                Type myType = typeof(Quartest);

                for (int i = 0; i < myType.GetFields().Length; i++)
                {
                    if (myType.GetFields()[i].Name == reserch)
                    {
                        var field = myType.GetType().GetField(reserch);
                        field.SetValue(this, (int)field.GetValue(QuartestValue) + 1);
                        break;
                    }
                }
            }
        }
        public async Task LevelParse()
        {
            _pathFile = SysConfig.GetLogPath();
            string json = await SearchRow(new string[] { "OwnedUnlocksCount" }).ConfigureAwait(false);
            JsonCharacterParse CharactersList = JsonConvert.DeserializeObject<JsonCharacterParse>(json);

            foreach (var character in CharactersList.CharactersList)
            {
                UpgradeNumeric UN = new()
                {
                    role = character.role,
                    collection = character.collection,
                    UnlocksUpgradeCount = character.OwnedUnlocksCount
                };
                LevelValue.Add(UN);
            }
        }
        private string ResourseParseSubstring(string row)
        {
            row = row.Substring(row.IndexOf("{\"sc"));
            row = row.Split("}}")[0] + "}";
            return row;
        }
        private string QuartestParseSubstring(string row)
        {
            row = row.Substring(row.IndexOf("{\"Physica\""));
            row = row.Split("},\"Curr ")[0] + "}";
            return row;
        }
        private string QuartestResearch(string row)
        {
            row = row.Substring(row.IndexOf("\"CurrentResearch\":{") + "\"CurrentResearch\":".Length);
            row = row.Split("},\"Boos")[0] + "}";
            var a = JsonConvert.DeserializeObject<dynamic>(row);

            if (a.FinishTime == "0001-01-01T00:00:00")
            {
                return null;
            }

            return a.TehnologyLine;
        }
        private async Task<string> SearchRow(string[] contains)
        {
            using (FileStream fs = new(_pathFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new(fs, Encoding.Default))
                {
                    long maxByte = 100000000;

                    long readingByte;
                    if (reader.BaseStream.Length > maxByte)
                        readingByte = maxByte;
                    else
                        readingByte = reader.BaseStream.Length;

                    _ = reader.BaseStream.Seek(-readingByte, SeekOrigin.End);

                    string? row;

                    int count = 0;
                    do
                    {
                        Debug.WriteLine(count);
                        row = await reader.ReadLineAsync().ConfigureAwait(false);

                        count++;

                        if (!string.IsNullOrWhiteSpace(row))
                        {
                            if (contains?.Length == 2)
                            {
                                if (row.Contains(contains[0]) || row.Contains(contains[1]))
                                    return row;
                            }
                            else if (contains?.Length == 1)
                                if (row.Contains(contains[0]))
                                    return row;
                        }
                    } while (!reader.EndOfStream);
                    return null;
                }
            }

        }
    }
}
