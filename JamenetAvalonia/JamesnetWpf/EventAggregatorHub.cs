using Prism.Events;
using System;
using System.Diagnostics;

namespace JamenetAvalonia.JamesnetWpf
{
    public class EventAggregatorHub : IEventHub
    {
        private IEventAggregator _ea;

        public Action<StackTrace> Publising { get; set; }

        public EventAggregatorHub(IEventAggregator ea)
        {
            Debug.WriteLine("new ea");
            _ea = ea;
        }

        public void Publish<T1, T2>(T2 value) where T1 : PubSubEvent<T2>, new()
        {
            StackTrace stackTrace = new StackTrace();
            Debug.WriteLine(stackTrace.GetFrame(1)!.GetMethod()!.Name);
            Publising?.Invoke(stackTrace);
            _ea.GetEvent<T1>().Publish(value);
        }

        public void Subscribe<T1, T2>(Action<T2> action) where T1 : PubSubEvent<T2>, new()
        {
            _ea.GetEvent<T1>().Subscribe(action);
        }
    }
}
