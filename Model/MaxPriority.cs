using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class MaxPriority : Priority
    {
        static readonly PriceUpgradesClasses _CharactersUpgrade;
        static readonly List<CharacterUpgrade> _CharactersLevels;
        static readonly int _CharacterMaxLvl = 14;

        static MaxPriority()
        {
           _CharactersUpgrade = StaticObject.GetPriceCharactersUpgrade();
           _CharactersLevels = LogObject.GetCharactersLevels();
        }

        public static void SetPriority()
        {
            _limitResourseValue = GetMaxPrise();
            SetDesiredNumber();
            OrderPriority();
            UpdateData();
        }
        public static ResourseValue GetMaxPrise()
        {
            return ResourseValue.Sum(GetQuarterPrise(), GetCharacterPrice());
        }
        public static ResourseValue GetQuarterPrise()
        {
            return TehnologiesPriority.GetPrice();
        }
        public static ResourseValue GetCharacterPrice()
        {
            ResourseValue resultValue = new();
            foreach (var character in _CharactersLevels)
            {
                int unlockUpgrades = character.OwnedUnlocksCount - 1;
                int lockUpgrades = _CharacterMaxLvl - unlockUpgrades;

                ResourseValue upgradePrice = character.role switch
                {
                    Classes.Assault => ResourseValue.Sum(_CharactersUpgrade.Assault.GetRange(unlockUpgrades, lockUpgrades)),
                    Classes.Gunner => ResourseValue.Sum(_CharactersUpgrade.Gunner.GetRange(unlockUpgrades, lockUpgrades)),
                    Classes.Medic => ResourseValue.Sum(_CharactersUpgrade.Medic.GetRange(unlockUpgrades, lockUpgrades)),
                    Classes.Sniper => ResourseValue.Sum(_CharactersUpgrade.Sniper.GetRange(unlockUpgrades, lockUpgrades))
                };

                resultValue = ResourseValue.Sum(resultValue, upgradePrice);
            }
            return resultValue;
        }
    }
}
