using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WPFCaliber.Value;
using static Caliber.Json.StaticObject;

namespace Caliber
{
    public partial class StaticObject
    {
        static readonly string _StaticPath;
        static readonly dynamic _StaticObject;
        static StaticObject()
        {
            _StaticPath = SysConfig.GetStaticPath();
            _StaticObject = GetStatic();
        }
        private static dynamic GetStatic()
        {
            string staticJSON = File.ReadAllText(_StaticPath);
            dynamic deserializedStatic = JsonConvert.DeserializeObject(staticJSON);
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
            //int[] recruitId = { 0, 1, 2, 3 };     разработчики сломали id карточек
            //int[] ww2Id = { 60, 61, 62, 63 };

            PriceUpgradesClasses priceUpgrades = new();

            foreach (var character in _StaticObject.CharacterCards)
            {
                if (character.collection == "RUS_RECRUIT" || character.collection == "SOV_WW2")
                    continue;

                List<ResourseValue> price = new();

                foreach (var ability in character.abilities)
                {
                    foreach (var upgrade in ability.upgrades)
                    {
                        price.Add(ToResourseValue(upgrade.cost.values));
                    }
                }
                foreach (var item in character.items)
                {
                    foreach (var upgrade in item.upgrades)
                    {
                        price.Add(ToResourseValue(upgrade.cost.values));
                    }
                }
                foreach (var perk in character.perks)
                {
                    price.Add(ToResourseValue(perk.cost.values));
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
        private static ResourseValue ToResourseValue(dynamic resourses)
        {
            ResourseValue resourse = new();
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            var resourseValueField = typeof(ResourseValue).GetFields();

            foreach (var item in resourses)
            {
                JProperty jProperty = item;

                foreach (FieldInfo field in resourseValueField)
                {
                    string jsonFieldName = field.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;

                    if (jsonFieldName == jProperty.Name)
                        field.SetValue(resourse, jProperty.Value.ToObject<int>());
                }
            }
            return resourse;
        }
    }
}
