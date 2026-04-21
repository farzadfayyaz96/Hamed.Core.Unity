using Code.Shared.Collections;
using Code.Shared.Helpers;
using Code.Shared.Types;
using Zenject;
using IServiceProvider = Code.Shared.Collections.Abstractions.IServiceProvider;

namespace Code.GamePlay.Installers
{
    public class GamePlayInstaller : MonoInstaller<GamePlayInstaller>
    {
        public override void InstallBindings()
        {
            var instances = TypeHelper.FindObjects<IServiceProvider>();
            
            var collection = new ServiceCollection();

            foreach (var sp in instances)
            {
                sp.Build();
                collection.Add(sp.Services);
            }
            

            foreach (var currentService in collection)
            {
                if (currentService.InjectionType == ServiceInjectionType.Transient)
                {
                    if (currentService.ImplementationType == null)
                    {
                        Container.Bind(currentService.Type).AsTransient();
                        continue;
                    }

                    Container.Bind(currentService.Type)
                        .To(currentService.ImplementationType)
                        .AsTransient();
                    continue;
                }
                
                //single
                if (currentService.ImplementationType == null)
                {
                    Container.Bind(currentService.Type).AsSingle();
                    continue;
                }

                Container.Bind(currentService.Type)
                    .To(currentService.ImplementationType)
                    .AsSingle();
                
            }
        }
        
        
    }
}