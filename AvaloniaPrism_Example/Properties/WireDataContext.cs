using AvaloniaPrism.Forms.Local.ViewModels;
using AvaloniaPrism.Forms.UI.Views;
using JamenetAvalonia.JamesnetWpf;

namespace AvaloniaPrism_Example.Properties
{
    public class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainWindow, MainViewModel> ();
        }
    }
}
