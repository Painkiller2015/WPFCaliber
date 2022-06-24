﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WPFCaliber;
using WPFCaliber.Value;
using System.Reflection;
using System.Runtime.CompilerServices;

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
                FieldInfo[]? resourseValueFields = typeof(ResourseValue).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                var resourse = LogObject.GetResourseValue();

                int j = 0;
                foreach (var resourseField in resourseValueFields)
                {
                    if (resourseField.Name == "<sc>k__BackingField")
                        continue;

                    int resValue = (int)resourseField.GetValue(resourse);
                    Resourse.DictNumResources.Add((ResoursesCollectionEng)j, new((ResoursesCollectionEng)j, resValue, resValue));
                    string resourseName = Enum.GetName((ResoursesCollectionEng)j);
                    Resourse.DictNumResources.Last().Value.ResourseImg = new(new Uri($"pack://application:,,,/Resourses/{resourseName}.png"));
                    j++;
                }
            }
            base.OnStartup(e);
        }
    }
}
