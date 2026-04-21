using Code.Shared.Collections;
using Code.Shared.Collections.Abstractions;

namespace Code.Core.Providers
{
    public class CoreServiceProvider :IServiceProvider
    {
        public ServiceCollection Services { get; } = new();
        
        
        public void Build()
        {
                
        }
    }
}