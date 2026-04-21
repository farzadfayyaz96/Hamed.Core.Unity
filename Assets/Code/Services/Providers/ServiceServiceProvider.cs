using Code.Shared.Collections;
using Code.Shared.Collections.Abstractions;

namespace Code.Services.Providers
{
    public class ServiceServiceProvider:IServiceProvider
    {
        public ServiceCollection Services { get; } = new();
        public void Build()
        {
            Services.AddTransient<ScoreService>();
        }
    }
}