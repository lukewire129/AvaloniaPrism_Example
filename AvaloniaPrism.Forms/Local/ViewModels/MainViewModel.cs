using JamenetAvalonia.Controls;
using JamenetAvalonia.Mvvm;
using Jamesnet.Wpf.Controls;
using Prism.Events;
using Prism.Ioc;
using Prism.Regions;

namespace AvaloniaPrism.Forms.Local.ViewModels
{
    public partial class MainViewModel : ObservableBase, IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly IEventAggregator _eh;
        public string Greeting => "Welcome to Avalonia!";

        public MainViewModel(IRegionManager regionManager,
                                                IContainerProvider containerProvider,
                                                IEventAggregator eh)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _eh = eh;
        }

        public void OnLoaded(IViewable view)
        {
            IRegion mainRegion = _regionManager.Regions["Main"];
            IViewable loginContent = _containerProvider.Resolve<IViewable> ("Main");

            if (!mainRegion.Views.Contains (loginContent))
            {
                mainRegion.Add (loginContent);
            }
            mainRegion.Activate (loginContent);
        }
    }
}