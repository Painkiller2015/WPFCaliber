using Caliber.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFCaliber.Model;
using static Caliber.Json.StaticObject;
using Application = System.Windows.Application;

namespace Caliber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PriorityMode priorityMode = PriorityMode.Auto;
        GlobalHotKeyManager GHKManager = new();
        public MainWindow()
        {
            InitializeComponent();
            ControlButton.Visibility = Visibility.Collapsed;

            ModeViewModel.ModeChanged += (obj, mode) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    priorityMode = mode;
                    ActualPriority.SetPriority(priorityMode);
                    ControlButton.Visibility = mode == PriorityMode.Hand ? Visibility.Visible : Visibility.Collapsed;
                });
            };
            ActuallyPriorityViewModel.PriorityChanged += (obj, resourses) =>
            {
                Application.Current.Dispatcher.Invoke(() => { PriorityResourse.ItemsSource = resourses; });
            };
            NeededResoursesViewModel.NeededResoursesEvent += (obj, resourses) =>
            {
                Application.Current.Dispatcher.Invoke(() => { NeededResourses.ItemsSource = resourses; });
            };
            DifferendResourseViewModel.DifferendResourses += (obj, resourses) =>
            {
                Application.Current.Dispatcher.Invoke(() => { DifferendResourses.ItemsSource = resourses; });
            };
            GHKManager.StatusProcessEvent += (obj, status) =>
            {
                WindowState = status == true ? WindowState.Minimized : WindowState;
            };

        }
    }
}
