using TransparentWindow.Home.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace TransparentWindow.Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var rm = containerProvider.Resolve<IRegionManager>();
            rm.RegisterViewWithRegion(nameof(MainMenu), typeof(MainMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}