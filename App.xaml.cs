using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WPFCaliber;
using WPFCaliber.Value;

namespace Caliber
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (!Resourse.DictNumResources.Any())
            {
                for (int i = 0; i < Enum.GetValues<ResoursesCollectionEng>().Length; i++)
                {
                    if (!Resourse.DictNumResources.ContainsKey((ResoursesCollectionEng)i))
                    {
                        var rsourseValueFields = typeof(ResourseValue).GetFields();
                        var resourse = LogObject.GetResourseValue();

                        foreach (var resourseField in rsourseValueFields)
                        {
                            int resValue = (int)resourseField.GetValue(resourse);
                            Resourse.DictNumResources.Add((ResoursesCollectionEng)i, new((ResoursesCollectionEng)i, resValue, resValue));
                        }

                        string resourseName = Enum.GetName((ResoursesCollectionEng)i);
                        Resourse.DictNumResources.Last().Value.ResourseImg = new(new Uri($"pack://application:,,,/Resourses/{resourseName}.png"));
                    }
                }
            }
            base.OnStartup(e);
        }
    }
}
