using Code.Core.Models;
using Code.Core.Repositories.Abstractions;
using UnityEngine;

namespace Code.Data.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        private const string ScoreKey = "Score";
        
        public void Save(ScoreCoreModel score)
        {
            PlayerPrefs.SetInt(ScoreKey, score.Value);
            PlayerPrefs.Save();
        }

        public ScoreCoreModel Get(int defaultValue = 0)
        {
            
            var score = PlayerPrefs.GetInt(ScoreKey, defaultValue);
            return new ScoreCoreModel
            {
                Value = score
            };
        }
    }
}