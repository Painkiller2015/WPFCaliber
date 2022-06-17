using Caliber.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace Caliber
{
    public class ActualPriority
    {
        public List<Resourse> Priority { get; }
        int _resourseLimit { get; set; } = Convert.ToInt32(new ResoursesLimitViewModel().ResoursesLimit);
        public ActualPriority(PriorityMode mode)
        {


            Priority = mode switch
            {
                PriorityMode.Hand => HandPriority(),
                PriorityMode.Max => MaxPriority().Result,
                PriorityMode.Median => MedianPriority(),
                PriorityMode.Tehnologies => TehnologiesPriority()

            };
        }

        //TODO Брать с формы выставленный юзером лист 
        #region HandPriority
        private List<Resourse> HandPriority()
        {
            List<Resourse> priority = new ActuallyPriorityViewModel().ActuallyPriority;
            priority = OutOverLimitResourses(priority);
            return priority;
        }

        #endregion HandPriority

        #region MaxPriority
        private async Task<List<Resourse>> MaxPriority()
        {
            List<Resourse> resoursesPrise = new();

            JsonResourseQuartestLevelParse lp = new();
            await lp.LevelParse();

            foreach (var oper in lp.LevelValue)
            {
                if (oper.collection == "RUS_RECRUIT") continue;
                switch (oper.role)
                {
                    case Classes.Assault:
                        for (int i = oper.UnlocksUpgradeCount; i < 15; i++) //15 - количество уровней прокачки (без скинов)
                        {
                            //ResoursePriceOnClass.Assault[i + 1].
                        }
                        break;

                    case Classes.Gunner:
                        break;

                    case Classes.Medic:
                        break;

                    case Classes.Sniper:
                        break;
                }
            }
            return null;
        }
        #endregion MaxPriority

        #region MedianPriority
        private List<Resourse> MedianPriority()
        {
            List<Resourse> resoursesOrderByNumber = Resourse.DictNumResources.Values.OrderBy(el => el.Number).ToList();
            List<Resourse> priority = OutOverLimitResourses(resoursesOrderByNumber);
            return priority;
        }
        #endregion MedianPriority

        #region TehnologiesPriority 
        private List<Resourse> TehnologiesPriority()
        {
            List<Resourse> priority = new();

            Quartest qv = new QuartesLevels().QuartesLevel;
            var quartestType = typeof(Quartest);
            var techLinesPrise = Technologylines.TechnologyLines;

            ResourseValue resoursesPriseResult = new();

            foreach (var techLine in techLinesPrise)
            {
                foreach (var quartest in typeof(Quartest).GetFields())
                {
                    for (int i = (int)quartest.GetValue(qv); i < techLine.Technologies.Length; i++)
                    {
                        ResourseValue actualPrice = techLine.Technologies[i].Price.values;

                        foreach (var field in typeof(ResourseValue).GetFields())
                        {
                            field.SetValue(resoursesPriseResult, (int)field.GetValue(resoursesPriseResult) + (int)field.GetValue(actualPrice));
                        }
                    }
                }
            }
            foreach (var quartest in typeof(ResourseValue).GetFields())
            {
                priority.Add(new Resourse { Number = (int)quartest.GetValue(resoursesPriseResult) });
            }
            return OutHavenResourses(priority);
        }

        #endregion TehnologiesPriority
        private List<Resourse> OutHavenResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {
                switch (item.Name)
                {
                    case ResoursesCollectionEng.alloy:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.alloy].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.component:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.component].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.fuel:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.fuel].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.medicine:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.medicine].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.chemistry:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.chemistry].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.composite:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.composite].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.encryption:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.encryption].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.blueprint:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.blueprint].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.microchip:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.microchip].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    case ResoursesCollectionEng.secretdev:
                        if (item.Number < Resourse.DictNumResources[ResoursesCollectionEng.secretdev].Number)
                        {
                            priority.Remove(item);
                        }
                        break;
                    default: 
                        return null;
                }
            }
            return priority;
        }
        private List<Resourse> OutOverLimitResourses(List<Resourse> priority)
        {
            foreach (var item in priority)
            {
                if (item.Number > _resourseLimit)
                {
                    priority.Remove(item);
                }
            }
            return priority;
        }
    }
}
