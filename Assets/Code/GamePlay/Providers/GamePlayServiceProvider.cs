using Code.Core.Events.Abstractions;
using Code.GamePlay.Events;
using Code.Shared.Collections;
using Code.Shared.Collections.Abstractions;

namespace Code.GamePlay.Providers
{
    public class GamePlayServiceProvider : IServiceProvider
    {
        public ServiceCollection Services { get; } =  new();
        
        
        public void Build()
        {
            Services.AddTransient<IEventBus, GamePlayEventBus>();    
        }
    }
}