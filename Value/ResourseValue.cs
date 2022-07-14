using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WPFCaliber.Value
{
   // [JsonObject]
    public class ResourseValue
    {
        [JsonProperty("sc")]
        public int sc;
        [JsonProperty("cm_t1_alloy")]
        public int alloy;
        [JsonProperty("cm_t1_component")]
        public int component;
        [JsonProperty("cm_t1_fuel")]
        public int fuel;
        [JsonProperty("cm_t1_medicine")]
        public int medicine;
        [JsonProperty("cm_t2_chemistry")]
        public int chemistry;
        [JsonProperty("cm_t2_composite")]
        public int composite;
        [JsonProperty("cm_t2_encryption")]
        public int encryption;
        [JsonProperty("cm_t3_blueprint")]
        public int blueprint;
        [JsonProperty("cm_t3_microchip")]
        public int microchip;
        [JsonProperty("cm_t4_secretdev")]
        public int secretdev;
        public static ResourseValue Sum(ResourseValue rv1, ResourseValue rv2)
        {
            ResourseValue resultValue = new ResourseValue();
            var resourseValueFields = typeof(ResourseValue).GetFields();

            foreach (var field in resourseValueFields)
            {
                int firstValue = (int)field.GetValue(rv1);
                int secondValuse = (int)field.GetValue(rv2);
                field.SetValue(resultValue, firstValue + secondValuse);
            }
            return resultValue;
        }
        public static ResourseValue Sum(List<ResourseValue> resourseValues)
        {
            ResourseValue resultValue = new();
            foreach (var resourseValue in resourseValues)
            {
                resultValue = ResourseValue.Sum(resultValue, resourseValue);
            }
            return resultValue;
        }
        public static ResourseValue Sub(ResourseValue rv1, ResourseValue rv2)
        {
            ResourseValue resultValue = new ResourseValue();
            var resourseValueFields = typeof(ResourseValue).GetFields();

            foreach (var field in resourseValueFields)
            {
                int firstValue = (int)field.GetValue(rv1);
                int secondValuse = (int)field.GetValue(rv2);
                field.SetValue(resultValue, firstValue - secondValuse);
            }
            return resultValue;
        }
    }
}
