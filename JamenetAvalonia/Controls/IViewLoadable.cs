﻿using JamenetAvalonia.Controls;

namespace Jamesnet.Wpf.Controls
{
    public interface IViewLoadable
    {
        void OnLoaded(IViewable view);
    }
}