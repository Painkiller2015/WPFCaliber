using Caliber;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPFCaliber.Value
{
    public class PriceUpgradesClasses
    {
        public List<ResourseValue> Assault { get; set; } = new();
        public List<ResourseValue> Gunner { get; set; } = new();
        public List<ResourseValue> Medic { get; set; } = new();
        public List<ResourseValue> Sniper { get; set; } = new();
        private static int _MaxLvl = 15;

        public ResourseValue Sum(int startInd, Classes characterClass)
        {
            PriceUpgradesClasses? upgradeList = StaticObject.GetPriceCharactersUpgrade();
            ResourseValue resourseValue = new();

            string characterClassName = Enum.GetName(characterClass);
            FieldInfo characterClassField = typeof(PriceUpgradesClasses).GetField(characterClassName);

            for (int upgradeId = startInd; upgradeId < _MaxLvl; upgradeId++) //TODO старт индекс с 0 или 1 ??? 
            {
                List<ResourseValue> price = (List<ResourseValue>)characterClassField.GetValue(upgradeList);
                resourseValue = ResourseValue.Sum(resourseValue, price[upgradeId]);
            }
            return resourseValue;
        }
    }
}
