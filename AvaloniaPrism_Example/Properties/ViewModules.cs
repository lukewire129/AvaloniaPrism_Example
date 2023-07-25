using AvaloniaPrism.Main.UI.Views;
using JamenetAvalonia.Controls;
using Prism.Ioc;
using Prism.Modularity;

namespace AvaloniaPrism_Example.Properties
{
    public class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent> ("Main");
        }
    }
}
