using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPFCaliber.Value;

namespace Caliber
{
    public partial class StaticObject
    {
        static readonly string _StaticPath = SysConfig.GetStaticPath();
        static readonly Json.StaticObject.Static _StaticObject = GetStatic();

        private static Json.StaticObject.Static GetStatic()
        {
            string av = File.ReadAllText(_StaticPath);
            var deserializedStatic = JsonConvert.DeserializeObject<Json.StaticObject.Static>(av);
            return deserializedStatic;
        }

        public static PriceQuartesTehologies GetQuartersPrise()
        {
            PriceQuartesTehologies priceQuartes = new();
            FieldInfo[] priceQuartesTehologiesFields = typeof(PriceQuartesTehologies).GetFields();

            int field = 0;

            foreach (var quarter in _StaticObject.Quarters.TechnologyLines)
            {
                List<ResourseValue> price = new();

                foreach (var quarterLevel in quarter.Technologies)
                {
                    price.Add(quarterLevel.Price.Values);
                }
                priceQuartesTehologiesFields[field].SetValue(priceQuartes, price);
                field++;
            }
            return priceQuartes;
        }
        public static PriceUpgradesClasses GetPriceCharactersUpgrade()
        {
            int[] recruitId = { 0, 1, 2, 3 };
            int[] ww2Id = { 60, 61, 62, 63 };

            PriceUpgradesClasses priceUpgrades = new();

            foreach (var character in _StaticObject.CharacterCards)
            {
                if (Array.IndexOf(recruitId, character.Id) == -1 ||
                    Array.IndexOf(ww2Id, character.Id) == -1)
                    continue;

                List<ResourseValue> price = new();

                foreach (var ability in character.Abilities)
                {
                    foreach (var upgrade in ability.Upgrades)
                    {
                        price.Add(upgrade.Cost.Values);
                    }
                }
                foreach (var item in character.Items)
                {
                    foreach (var upgrade in item.Upgrades)
                    {
                        price.Add(upgrade.Cost.Values);
                    }
                }
                foreach (var perk in character.Perks)
                {
                    price.Add(perk.Cost.Values);
                }
                price.OrderBy(el => el.sc);

                switch (character.Role)
                {
                    case Classes.Assault:
                        priceUpgrades.Assault = price;
                        break;
                    case Classes.Gunner:
                        priceUpgrades.Gunner = price;
                        break;
                    case Classes.Medic:
                        priceUpgrades.Medic = price;
                        break;
                    case Classes.Sniper:
                        priceUpgrades.Sniper = price;
                        break;
                }
            }
            return priceUpgrades;
        }
    }
}
