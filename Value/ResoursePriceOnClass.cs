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
        private const int _ClassesCount = 4;

        static ResoursePriceOnClass()
        {
            string json = File.ReadAllText(SysConfig.GetLogPath());
            JsonCharacterParse CharactersList = JsonConvert.DeserializeObject<JsonCharacterParse>(json);

            int recruitCount = 0;
            int classesCount = 0;

            foreach (var character in CharactersList.CharactersList)
            {
                if (recruitCount < _RecruitCount)
                {
                    recruitCount++;
                    continue;
                }
                if (classesCount < _ClassesCount)
                {
                    classesCount++;
                }
                else { break; }

                foreach (var abilities in character.abilities)
                {
                    foreach (var upgrades in abilities.upgrades)
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
        public ResourseValue Sum(int startInd, Classes characterClass)
        {
            ResourseValue rasourseValue = new();

            string characterClassName = Enum.GetName(characterClass);

            FieldInfo[]? resourseValueFields = typeof(ResourseValue).GetFields();
            FieldInfo? classFieldOnName = typeof(ResoursePriceOnClass).GetField(characterClassName);

            for (int numLvl = startInd + 1; numLvl < _MaxLvl; numLvl++)      //TODO +1 мб не надо                           
            {
                foreach (var fieldResourse in resourseValueFields)
                {
                    var resourseField = (List<ResourseValue>)classFieldOnName.GetValue(this);
                    fieldResourse.SetValue(rasourseValue, (int)fieldResourse.GetValue(rasourseValue) + resourseField[numLvl].GetValueOnName(fieldResourse.ToString()));
                }
            }
            return rasourseValue;
        }
    }
}
