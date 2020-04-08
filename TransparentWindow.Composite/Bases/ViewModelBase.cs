using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace TransparentWindow.Composite.Bases
{
    public class ViewModelBase : BindableBase
    {
        [Dependency]
        public IRegionManager regionManager;

        public ViewModelBase()
        {

        }
    }
}
