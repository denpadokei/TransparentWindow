using Prism.Ioc;
using TransparentWindow.Views;
using System.Windows;
using Prism.Modularity;
using TransparentWindow.Core;
using TransparentWindow.Home;
using TransparentWindow.Composite;

namespace TransparentWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CoreModule>();
            moduleCatalog.AddModule<CompositeModule>();
            moduleCatalog.AddModule<HomeModule>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
