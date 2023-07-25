using Prism.Mvvm;
using System.Collections.Generic;

namespace JamenetAvalonia.JamesnetWpf
{
    public class ViewModelLocatorCollection : List<ViewModelLocatorItem>
    {
        public void Register<T1, T2>()
        {
            ViewModelLocationProvider.Register<T1, T2>();
            Add(new ViewModelLocatorItem(typeof(T1), typeof(T2)));
        }
    }
}
