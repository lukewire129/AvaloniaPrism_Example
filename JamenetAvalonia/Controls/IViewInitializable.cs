using JamenetAvalonia.Controls;

namespace Jamesnet.Wpf.Controls
{
    public interface IViewInitializable
    {
        void OnViewWired(IViewable view);
    }
}