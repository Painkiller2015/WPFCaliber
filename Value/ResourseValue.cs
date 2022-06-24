using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFCaliber.Value
{
    public class ResourseValue
    {
        [JsonProperty("sc")]
        public int sc { get; set; }
        [JsonProperty("cm_t1_alloy")]
        public int alloy { get; set; }
        [JsonProperty("cm_t1_component")]
        public int component { get; set; }
        [JsonProperty("cm_t1_fuel")]
        public int fuel { get; set; }
        [JsonProperty("cm_t1_medicine")]
        public int medicine { get; set; }
        [JsonProperty("cm_t2_chemistry")]
        public int chemistry { get; set; }
        [JsonProperty("cm_t2_composite")]
        public int composite { get; set; }
        [JsonProperty("cm_t2_encryption")]
        public int encryption { get; set; }
        [JsonProperty("cm_t3_blueprint")]
        public int blueprint { get; set; }
        [JsonProperty("cm_t3_microchip")]
        public int microchip { get; set; }
        [JsonProperty("cm_t4_secretdev")]
        public int secretdev { get; set; }
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
