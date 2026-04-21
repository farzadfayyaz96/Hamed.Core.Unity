using Code.Core.Models;

namespace Code.Core.Repositories.Abstractions
{
    public interface IScoreRepository
    {
        void Save(ScoreCoreModel score);
        
        ScoreCoreModel Get(int defaultValue = 0);
        
    }
}