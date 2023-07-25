using Prism.Events;

namespace JamenetAvalonia.JamesnetWpf
{
    public class EventAggregatorBuilder
    {
        public static IEventHub Get(IEventAggregator ea)
        {
            return new EventAggregatorHub(ea);
        }
    }
}
