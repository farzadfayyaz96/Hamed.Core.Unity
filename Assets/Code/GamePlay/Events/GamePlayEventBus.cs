using Code.Core.Events.Abstractions;
using Zenject;

namespace Code.GamePlay.Events
{
    public class GamePlayEventBus :IEventBus
    {
        private readonly SignalBus _signalBus;

        public GamePlayEventBus(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        public void Fire<T>(T t)
        {
            _signalBus.Fire<T>(t);
        }
    }
}