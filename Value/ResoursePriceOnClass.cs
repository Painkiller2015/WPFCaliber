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
    public class ResoursePriceOnClass
    {
        public static List<ResourseValue> Assault { get; } = new();
        public static List<ResourseValue> Gunner { get; } = new();
        public static List<ResourseValue> Medic { get; } = new();
        public static List<ResourseValue> Sniper { get; } = new();

        private const int _MaxLvl = 15;
        private const int _RecruitCount = 4;

        static ResoursePriceOnClass()
        {
            string json = File.ReadAllText(SysConfig.GetLogPath());
            JsonCharacterParse CharactersList = JsonConvert.DeserializeObject<JsonCharacterParse>(json);

            int recruitCount = 0;

            foreach (var character in CharactersList.CharactersList)
            {
                foreach (var abilities in character.abilities)
                {
                    foreach (var upgrades in abilities.upgrades)
                    {
                        recruitCount++;
                        if (recruitCount > _RecruitCount && (Assault.Count != 15 || Sniper.Count != 15 || Medic.Count != 15 || Gunner.Count != 15))
                        {
                            switch (character.role)
                            {
                                case Classes.Assault:
                                    Assault.Add(upgrades.cost.values);
                                    break;
                                case Classes.Gunner:
                                    Gunner.Add(upgrades.cost.values);
                                    break;
                                case Classes.Medic:
                                    Medic.Add(upgrades.cost.values);
                                    break;
                                case Classes.Sniper:
                                    Sniper.Add(upgrades.cost.values);
                                    break;
                            }
                        }
                    }
                }
            }
        }
        public ResourseValue Sum(int StartInd, Classes Class)
        {
            ResourseValue RV = new();
            string className = Enum.GetName(Class);
            FieldInfo[]? typeResourseValueFields = typeof(ResourseValue).GetFields();
            FieldInfo? thisTypeFieldOnName = typeof(ResoursePriceOnClass).GetField(className);

            for (int NumLvl = StartInd; NumLvl < _MaxLvl; NumLvl++)                                 
            {
                int fieldResourseNum = 0;
                foreach (var fieldResourse in typeResourseValueFields)
                {
                    var Resoursefield = (List<ResourseValue>)thisTypeFieldOnName.GetValue(this);
                    fieldResourse.SetValue(RV, (int)fieldResourse.GetValue(RV) + Resoursefield[NumLvl].GetValueOnName(fieldResourse.ToString()));
                    fieldResourseNum++;
                }
            }
            return RV;
        }
    }
}
