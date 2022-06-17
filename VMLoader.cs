using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber
{
    public interface ITransient { }
    public interface ISingleton { }

    internal class VMLoader
    {
        private static readonly IServiceProvider Provider;

        static VMLoader()
        {
            ServiceCollection services = new();

            services.Scan(el =>
                el.FromAssemblyOf<ITransient>()
                    .AddClasses(cl => cl.AssignableTo<ITransient>()).AsSelf().WithTransientLifetime()
                    //.AddClasses(cl => cl.AssignableTo<ISingleton>()).AsSelf().WithSingletonLifetime()
                );
            services.Scan(el =>
                el.FromAssemblyOf<ISingleton>()
                    .AddClasses(cl => cl.AssignableTo<ISingleton>()).AsSelf().WithSingletonLifetime()
                );

            Provider = services.BuildServiceProvider();

            foreach (ServiceDescriptor service in services.Where(el => el.Lifetime == ServiceLifetime.Singleton))
                Provider.GetRequiredService(service.ServiceType);
        }

        public static T? Resolve<T>() => Provider.GetService<T>();
        public ViewModels.ActuallyPriorityViewModel? ActuallyPriorityViewModel { get => Resolve<ViewModels.ActuallyPriorityViewModel>(); }
        public ViewModels.LanguageSetterViewModel? LanguageSetterViewModel { get => Resolve<ViewModels.LanguageSetterViewModel>(); }
        public ViewModels.MainViewModel? MainViewModel { get => Resolve<ViewModels.MainViewModel>(); }
        public ViewModels.ModeDescriptionViewModel? ModeDescriptionViewModel { get => Resolve<ViewModels.ModeDescriptionViewModel>(); }
        public ViewModels.ModeViewModels? ModeViewModels { get => Resolve<ViewModels.ModeViewModels>(); }
        public ViewModels.NeededResoursesViewModel? NeededResoursesViewModel { get => Resolve<ViewModels.NeededResoursesViewModel>(); }
        public ViewModels.ResoursesLimitViewModel? ResoursesLimitViewModel { get => Resolve<ViewModels.ResoursesLimitViewModel>(); }
        public ViewModels.StartResoursesViewModel? StartResoursesViewModel { get => Resolve<ViewModels.StartResoursesViewModel>(); }
        public ViewModels.TakenResoursesViewModel? TakenResoursesViewModel { get => Resolve<ViewModels.TakenResoursesViewModel>(); }
    }
}
