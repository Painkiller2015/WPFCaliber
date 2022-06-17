using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Caliber
{
    public class Resourse
    {
        public Resourse()
        {
            if (!DictNumResources.Any())
            {
                var resourse = new JsonResourseQuartestLevelParse();
                resourse.ResourseParse();

                for (int i = 0; i < Enum.GetValues<ResoursesCollectionEng>().Length; i++)
                {
                    if (!DictNumResources.ContainsKey((ResoursesCollectionEng)i))
                    {
                        DictNumResources.Add((ResoursesCollectionEng)i, new((ResoursesCollectionEng)i, 0));


                        _ResourseImgName = Enum.GetName((ResoursesCollectionEng)i);
                        DictNumResources.Last().Value.ResourseImg = new(new Uri($"pack://application:,,,/Resourses/{_ResourseImgName}.png"));
                    }
                }
            }
        }

        public Resourse(ResoursesCollectionEng name, int numberResourses = 0)
        {
            Name = name;
            Number = numberResourses;


            //DictNumResources[name] = this;\

        }
        public ResoursesCollectionEng Name { get; set; }
        public int Number { get; set; }
        public int StartedNumber { get; set; }
        public int Priority { get; set; } = default;
        public int Tier { get; set; } = default;
        public int DiffNumber { get => Number - StartedNumber; }

        public BitmapImage? ResourseImg { get; set; }
        public string _ResourseImgName { get; set; }
        public static Dictionary<ResoursesCollectionEng, Resourse> DictNumResources { get; } = new();
    }
}