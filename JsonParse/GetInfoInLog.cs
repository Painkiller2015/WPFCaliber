using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace Caliber
{
    //TODO переделать на асинхронку
    public static partial class LogObject
    {
        static readonly string[] _CharactersInfoRow = { "get_all_cards" };
        static readonly string[] _AccountInfoRow = { "account/update" };
        static readonly string[] _QuartersResearchInfoRow = { "account/update" };
        static readonly string[] _ResourseValueRow =
        {
            "https://login.playcaliber.com/v1/account/close_loot_box",
            "https://login.playcaliber.com/v1/account/update"
        };
        static readonly string _LogPath = SysConfig.GetLogPath();
        static readonly Json.Accaunt.LogObject.Account _AccauntInfo = GetAccauntInfo();
        static readonly List<Json.Character.LogObject.Character> _CharactersInfo = GetCharactesInfo();

        public static Json.Accaunt.LogObject.Technologies GetQuarters()
        {
            var qurtest = _AccauntInfo.quarters.Technologies;
            qurtest = AddResearchQuarter(qurtest);
            return qurtest;
        }
        public static List<CharacterUpgrade> GetCharactersLevels()
        {
            int recruitCount = 3;
            List<CharacterUpgrade> upgrade = new List<CharacterUpgrade>();

            foreach (var item in _CharactersInfo)
            {
                if (item.id < recruitCount)
                {
                    recruitCount++;
                    continue;
                }
                upgrade.Add(
                    new CharacterUpgrade
                    {
                        collection = item.collection,
                        OwnedUnlocksCount = item.OwnedUnlocksCount,
                        role = item.role
                    });
            }
            return upgrade;
        }
        public static ResourseValue GetResourseValue()
        {
            return _AccauntInfo.money.values;
        }

        private static Json.Accaunt.LogObject.Account GetAccauntInfo()
        {
            string conteinLine = SearchRow(_AccountInfoRow, _LogPath).Result;
            var deserializedAccount = JsonConvert.DeserializeObject<Json.Accaunt.LogObject.Account>(conteinLine);
            return deserializedAccount;
        }
        private static List<Json.Character.LogObject.Character> GetCharactesInfo()
        {
            string ConteinLine = SearchRow(_CharactersInfoRow, _LogPath).Result;
            var deserializedCharacters = JsonConvert.DeserializeObject<List<Json.Character.LogObject.Character>>(ConteinLine);
            return deserializedCharacters;
        }
        private static async Task<string> SearchRow(string[] contains, string path)
        {
            using (FileStream fs = new(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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
        private static Json.Accaunt.LogObject.Technologies AddResearchQuarter(Json.Accaunt.LogObject.Technologies technologies)
        {
            var accauntInfo = GetAccauntInfo();
            string? reserch = accauntInfo.quarters.CurrentResearch.TechnologyLine;
            if (!string.IsNullOrEmpty(reserch))
            {
                var techologiesFields = technologies.GetType().GetFields();

                foreach (var quarterField in techologiesFields)
                {
                    if (reserch == quarterField.Name)
                    {
                        quarterField.SetValue(technologies, (int)quarterField.GetValue(technologies) + 1);
                        return technologies;
                    }
                }
            }
            return technologies;
        }

    }
}

