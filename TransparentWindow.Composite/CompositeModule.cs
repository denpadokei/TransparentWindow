using TransparentWindow.Composite.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TransparentWindow.Composite.Interfaces;
using TransparentWindow.Composite.Services;

namespace TransparentWindow.Composite
{
    public class CompositeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ILoadingService, LoadingService>();
        }
    }
}