using Caliber;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Caliber.Json.Character.LogObject;

namespace WPFCaliber.Value
{
    public static class PriceUpgradesClasses
    {
        public static List<ResourseValue> Assault;
        public static List<ResourseValue> Gunner;
        public static List<ResourseValue> Medic;
        public static List<ResourseValue> Sniper;
        private static int _CharacterMaxLvl = 15;

        static PriceUpgradesClasses()
        {
            StaticObject.GetPriceUpgradeOnClasses();
        }

        public static ResourseValue Sum(int startInd, Classes characterClass)
        {
            ResourseValue resourseValue = new();
            string? characterClassName = Enum.GetName(characterClass);

            int lockUpgades = _CharacterMaxLvl - startInd;

            List<ResourseValue> value = characterClassName switch
            {
                "Assault" => Assault,
                "Gunner" => Gunner,
                "Medic" => Medic,
                "Sniper" => Sniper
            };

            ResourseValue newResourseValue = ResourseValue.Sum(value.GetRange(startInd, lockUpgades));
            resourseValue = ResourseValue.Sum(resourseValue, newResourseValue);
            return resourseValue;
        }
    }
}
