using DryIoc;
using JamenetAvalonia.JamesnetWpf;
using Prism.DryIoc;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using System.Collections.Generic;

namespace JamenetAvalonia.Controls
{
    public abstract class JamesApplication : PrismApplication
    {
        private List<IModule> _modules = new List<IModule>();

        public JamesApplication AddInversionModule<T>() where T : IModule, new()
        {
            IModule item = new T();
            _modules.Add(item);
            return this;
        }

        public JamesApplication AddWireDataContext<T>() where T : ViewModelLocationScenario, new()
        {
            ViewModelLocationScenario viewModelLocationScenario = new T();
            viewModelLocationScenario.Publish();
            return this;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            foreach (IModule module in _modules)
            {
                moduleCatalog.AddModule(module.GetType());
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(typeof(IEventHub), EventAggregatorBuilder.Get(containerRegistry.GetContainer().Resolve<IEventAggregator>()));
        }

        public static T GetService<T>()
        {
            JamesApplication jamesApplication = Current as JamesApplication;
            if (jamesApplication != null)
            {
                return jamesApplication.Container.Resolve<T>();
            }

            return default;
        }
    }
}
