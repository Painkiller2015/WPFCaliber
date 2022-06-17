using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WPFCaliber;

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
                        //TODO достать значение ресурсов для начального заполнения DictNumResources
                        Resourse.DictNumResources.Add((ResoursesCollectionEng)i, new((ResoursesCollectionEng)i, 0));

                        string resourseName = Enum.GetName((ResoursesCollectionEng)i);
                        Resourse.DictNumResources.Last().Value.ResourseImg = new(new Uri($"pack://application:,,,/Resourses/{resourseName}.png"));
                    }
                }
            }
            base.OnStartup(e);
        }
    }
}
