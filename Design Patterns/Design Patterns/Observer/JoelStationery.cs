using System;

namespace Design_Patterns.Observer
{
    public class JoelStationery : IStore
    {
        public override void NewSubscriber(ISubscribe subscriber)
        {
            Console.WriteLine("Add a Subscribe");
            _Subsctibers.Add(subscriber);
        }

        public override void RemoveSubscriber(ISubscribe subscriber)
        {
            Console.WriteLine("Remove a Subscribe");
            _Subsctibers.Remove(subscriber);
        }

        public override void Notify()
        {
            if (_Subsctibers.Count > 0)
            {
                foreach (var sub in _Subsctibers)
                {
                    sub.Action();
                }
                return;
            }

            throw new Exception("You have no Subscribers");
        }
    }
}