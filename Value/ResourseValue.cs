using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
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
        public int GetValueOnName(string nameProperties)
        {
            return (int)typeof(ResourseValue).GetProperty(nameProperties).GetValue(this);
        }
    }
}
