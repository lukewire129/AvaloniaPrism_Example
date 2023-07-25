using Avalonia.Controls;
using JamenetAvalonia.Mvvm;

namespace JamenetAvalonia.Controls
{
    public interface IViewable
    {
        Control View { get; init; }
        ObservableBase ViewModel { get; }
    }
}