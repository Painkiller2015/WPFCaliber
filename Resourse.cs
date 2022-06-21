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
        public ResoursesCollectionEng Name { get; set; }
        public int Number { get; set; }
        public int StartedNumber { get; set; }
        public int Priority { get; set; } = default;
        public int Tier { get; set; } = default;
        public int DiffNumber { get => Number - StartedNumber; }
        public BitmapImage? ResourseImg { get; set; }
    
        public static Dictionary<ResoursesCollectionEng, Resourse> DictNumResources { get; set; } = new();
        public Resourse(ResoursesCollectionEng name, int numberResourses = 0)
        {
            Name = name;
            Number = numberResourses;
        }
        public Resourse(ResoursesCollectionEng name, int numberResourses = 0, int startedNumber = 0)
        {
            Name = name;
            Number = numberResourses;
            StartedNumber = startedNumber;
        }
    }
}