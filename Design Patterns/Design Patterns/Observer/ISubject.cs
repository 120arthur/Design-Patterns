namespace Design_Patterns.Observer
{
    public interface ISubject
    {
        void NewSubscriber(ISubscribe subscribers);
        void RemoveSubscriber(ISubscribe subscribers);
        void Notify();
    }
}