using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using TransparentWindow.Composite.Interfaces;
using Unity;

namespace TransparentWindow.Composite.Bases
{
    public class ViewModelBase : BindableBase
    {
        [Dependency]
        public IRegionManager regionManager;
        [Dependency]
        public ILoadingService loadingService;

        public ViewModelBase()
        {

        }
    }
}
