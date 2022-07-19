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
        static readonly List<CharacterUpgrade> _CharactersLevels;
        static MaxPriority()
        {
           _CharactersLevels = LogObject.GetCharactersLevels();
        }
        public static async Task SetPriority()
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
                int unlockLevels = character.OwnedUnlocksCount;

                ResourseValue upgradePrice = character.role switch
                {
                    Classes.Assault => PriceUpgradesClasses.Sum(unlockLevels, Classes.Assault),
                    Classes.Gunner => PriceUpgradesClasses.Sum(unlockLevels, Classes.Gunner),
                    Classes.Medic => PriceUpgradesClasses.Sum(unlockLevels, Classes.Medic),
                    Classes.Sniper => PriceUpgradesClasses.Sum(unlockLevels, Classes.Sniper)
                };

                resultValue = ResourseValue.Sum(resultValue, upgradePrice);
            }
            return resultValue;
        }
    }
}
