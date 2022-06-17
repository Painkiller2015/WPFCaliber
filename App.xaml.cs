using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
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
                    if (!Resourse.DictNumResources.Keys.Contains((ResoursesCollectionEng)i))
                    {
                        Resourse.DictNumResources.Add((ResoursesCollectionEng)i, new((ResoursesCollectionEng)i, 0));
                    }
                }
            }
            base.OnStartup(e);
        }
    }


}
