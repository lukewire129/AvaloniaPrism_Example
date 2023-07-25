using System;

namespace JamenetAvalonia.JamesnetWpf
{
    public class ViewModelLocatorItem
    {
        public Type ViewType { get; set; }

        public Type DataContextType { get; set; }

        public ViewModelLocatorItem(Type viewType, Type dataContextType)
        {
            ViewType = viewType;
            DataContextType = dataContextType;
        }
    }
}
