namespace Code.Core.Events.Abstractions
{
    public interface IEventBus
    {
        void Fire<T>(T t);
        
    }
}