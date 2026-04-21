using Code.Core.Events;
using Code.Core.Events.Abstractions;
using Code.Core.Models;
using Code.Core.Repositories.Abstractions;

namespace Code.Services
{
    public class ScoreService
    {
        private readonly IScoreRepository _scoreRepository;
        private readonly IEventBus _eventBus;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }


        public void Save(int score)
        {
            var coreModel = new ScoreCoreModel
            {
                Value = score
            };
            _scoreRepository.Save(coreModel);
            
            _eventBus.Fire(new ScoreUpdatedEvent
            {
                NewScoreValue = score
            });
        }
    }
}