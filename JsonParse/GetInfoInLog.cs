using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;
using static Caliber.Json.Character.LogObject;

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
        static readonly List<Character> _CharactersInfo = GetCharactesInfo();

        /*        static LogObject() 
                {
                    using (Json.Accaunt.LogObject.Account a = GetAccauntInfo())
                    {
                        _AccauntInfo = a;
                    };

                    using (var b = GetCharactesInfo())
                    {
                        _CharactersInfo = b;
                    };
                }
        */
        public static async Task<Json.Accaunt.LogObject.Technologies> GetQuarters()
        {
            var qurtest = _AccauntInfo.quarters.Technologies;
            qurtest = await AddResearchQuarter(qurtest);
            return qurtest;
        }
        public static List<CharacterUpgrade> GetCharactersLevels()
        {
            List<CharacterUpgrade> upgrade = new();

            foreach (var character in _CharactersInfo)
            {
                if (character.collection == "RUS_RECRUIT" || character.collection == "SOV_WW2")
                    continue;

                int unlockUpgradre = GetUnlockUpgrade(character.cfgId);

                unlockUpgradre = unlockUpgradre > 15 ? 15 : unlockUpgradre;

                upgrade.Add(
                    new CharacterUpgrade
                    {
                        collection = character.collection,
                        OwnedUnlocksCount = unlockUpgradre,
                        role = character.role
                    });
            }

            return upgrade;
        }

        private static int GetUnlockUpgrade(string characterName)
        {
            Character character = _CharactersInfo.Where(el => el.cfgId == characterName).First();

            int upgradeCount = 0;

            foreach (var abilitie in character?.abilities)
            {
                foreach (var upgrade in abilitie.upgrades)
                    if (upgrade.unlocked == true)
                        upgradeCount++;
            }

            foreach (var item in character?.items)
            {
                if (item?.upgrades == null)
                    continue;
                foreach (var upgrades in item?.upgrades)
                    if (upgrades.unlocked == true)
                        upgradeCount++;
            }

            foreach (var perk in character?.perks)
                if (perk?.unlocked == true)
                    upgradeCount++;

            return upgradeCount;
        }

        public static ResourseValue GetResourseValue()
        {
            return _AccauntInfo.money.values;
        }

        private static Json.Accaunt.LogObject.Account GetAccauntInfo()
        {
            string conteinLine = SearchRow(_AccountInfoRow, _LogPath).Result;
            conteinLine = conteinLine.Remove(0, 66);//TODO сделать нормально
            var deserializedAccount = JsonConvert.DeserializeObject<Json.Accaunt.LogObject.Account>(conteinLine);
            return deserializedAccount;
        }
        private static List<Character> GetCharactesInfo()
        {
            string conteinLine = SearchRow(_CharactersInfoRow, _LogPath).Result;
            conteinLine = conteinLine.Remove(0, 73);//TODO сделать нормально
            var deserializedCharacters = JsonConvert.DeserializeObject<List<Character>>(conteinLine);
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
        private static async Task<Json.Accaunt.LogObject.Technologies> AddResearchQuarter(Json.Accaunt.LogObject.Technologies technologies)
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