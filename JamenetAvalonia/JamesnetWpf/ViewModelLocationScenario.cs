namespace JamenetAvalonia.JamesnetWpf
{
    public abstract class ViewModelLocationScenario
    {
        internal ViewModelLocatorCollection Publish()
        {
            ViewModelLocatorCollection viewModelLocatorCollection = new ViewModelLocatorCollection();
            Match(viewModelLocatorCollection);
            return viewModelLocatorCollection;
        }

        public ViewModelLocationScenario()
        {
        }

        protected abstract void Match(ViewModelLocatorCollection items);
    }
}
