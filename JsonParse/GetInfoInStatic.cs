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
        /*        public static ResourseValue GetPriceUpgrades()
                {

                }*/
        public static void GetPriceUpgradeOnClasses()
        {
            //int[] recruitId = { 0, 1, 2, 3 };     разработчики сломали id карточек
            //int[] ww2Id = { 60, 61, 62, 63 };

            foreach (var character in _StaticObject.CharacterCards)
            {
                if (character.collection == "RUS_RECRUIT" || character.collection == "SOV_WW2")
                    continue;

                List<ResourseValue> price = new();

                foreach (var ability in character?.abilities)
                    foreach (var upgrade in ability?.upgrades)
                        price.Add(ToResourseValue(upgrade.cost.values));

                foreach (var item in character?.items)
                {
                    if (item?.upgrades == null)
                        continue;

                    foreach (var upgrade in item?.upgrades)
                        price.Add(ToResourseValue(upgrade.cost.values));
                }
                foreach (var perk in character?.perks)
                    price.Add(ToResourseValue(perk.cost.values));

                price = price.OrderBy(el => el.sc).ToList();

                bool sniper = false, medic = false, gunner = false, assault = false;

                switch ((Classes)character.role.Value)
                {
                    case Classes.Assault:
                        PriceUpgradesClasses.Assault = price;
                        assault = true;
                        break;
                    case Classes.Gunner:
                        PriceUpgradesClasses.Gunner = price;
                        gunner = true;
                        break;
                    case Classes.Medic:
                        PriceUpgradesClasses.Medic = price;
                        medic = true;
                        break;
                    case Classes.Sniper:
                        PriceUpgradesClasses.Sniper = price;
                        sniper = true;
                        break;
                }
                if (sniper & medic & gunner & assault)
                    break;
            }
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
