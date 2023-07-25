using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using AvaloniaPrism.Forms.UI.Views;
using AvaloniaPrism_Example.Properties;
using JamenetAvalonia.Controls;

namespace AvaloniaPrism_Example
{
    public class App : JamesApplication
    {
        public App()
        {
            this.RequestedThemeVariant = ThemeVariant.Default;
            this.Styles.Add(new FluentTheme ());

            this.AddInversionModule<ViewModules> ();
            this.AddInversionModule<DirectModules> ();
            this.AddWireDataContext<WireDataContext> ();
        }
        protected override Window CreateShell()
        {
            return new MainWindow ();
        }
    }
}
