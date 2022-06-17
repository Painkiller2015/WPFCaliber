using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliber.ViewModels;
using System.IO;
using Newtonsoft.Json;
using WPFCaliber.Value;

namespace Caliber
{
    public class TehnologiesPriority
    {
        //TODO доделать

        private readonly PriceQuartesTehologies _priceQuartes;
        public WPFCaliber.Value.ResourseValue ActualNeededResourses { get; set; } 
        public TehnologiesPriority()
        {
            string json = File.ReadAllText(@"../QuartersTechonologiesResourse.json"); // читать их статика 
            _priceQuartes = JsonConvert.DeserializeObject<PriceQuartesTehologies>(json);

            foreach (var item in typeof(WPFCaliber.Value.ResourseValue).GetProperties())
            {
                item.SetValue(ActualNeededResourses, _priceQuartes.Sum(item.Name));
            }
        }
        public List<Resourse> GetPriority()
        {
            foreach (var item in typeof(TehnologiesPriority).GetProperties())
            {
                item.GetValue(this);
            }
            //_priceQuartes.Ammunition.GetRange(6, _priceQuartes.Ammunition.Count - 7).Sum(el => el.fuel + el.chemistry + el.);

            WPFCaliber.Value.ResourseValue resourseValue = new WPFCaliber.Value.ResourseValue();

            ActuallyPriorityViewModel actuallyPriority = new ActuallyPriorityViewModel();

            //List<Resourse> priority = actuallyPriority.GetPriority("Tehnologies");

            return null;
        }
    }
}
