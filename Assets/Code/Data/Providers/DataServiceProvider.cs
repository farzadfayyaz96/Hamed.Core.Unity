using Code.Core.Repositories.Abstractions;
using Code.Data.Repositories;
using Code.Shared.Collections;
using Code.Shared.Collections.Abstractions;

namespace Code.Data.Providers
{
    public class DataServiceProvider:IServiceProvider
    {

        public ServiceCollection Services { get; } = new();
        
        public void Build()
        {
            Services.AddTransient<IScoreRepository, ScoreRepository>();
        }
    }
}