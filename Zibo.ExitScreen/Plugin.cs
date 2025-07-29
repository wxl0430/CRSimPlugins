using CRSim.Core.Abstractions;
using CRSim.Core.Attributes;
using Zibo.ExitScreen.ViewModels;
using Zibo.ExitScreen.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Zibo.ExitScreen
{
    [PluginEntrance]
    public class Plugin : PluginBase
    {
        public override Type ViewModel => typeof(ScreenViewModel);

        public override Type View => typeof(ScreenView);

        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            services.AddTransient(ViewModel);
            services.AddTransient(View);
        }
    }
}