using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public class ScoreRecord : Subject
    {
        private readonly List<int> scores = new List<int>();

        public void AddScore(int score)
        {
            scores.Add(score);
            NotifyObservers();
        }

        public List<int> GetScoreRecord()
        {
            return scores;
        }
    }
}