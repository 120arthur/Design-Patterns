using System.Collections.Generic;

namespace Design_Patterns.Observer
{
    public abstract class IStore : ISubject
    {
        protected List<ISubscribe> _Subsctibers = new List<ISubscribe>();


        public abstract void NewSubscriber(ISubscribe Subscriber);
        public abstract void RemoveSubscriber(ISubscribe Subscriber);
        public abstract void Notify();

    }
}