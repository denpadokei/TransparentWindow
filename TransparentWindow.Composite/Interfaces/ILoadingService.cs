using System;
using System.Collections.Generic;
using System.Text;

namespace TransparentWindow.Composite.Interfaces
{
    public interface ILoadingService
    {
        void Load(Action load);
    }
}
