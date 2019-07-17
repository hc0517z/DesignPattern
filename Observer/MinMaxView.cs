using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Observer
{
    public class MinMaxView : IObserver
    {
        private ScoreRecord scoreRecord;

        public MinMaxView(ScoreRecord scoreRecord)
        {
            this.scoreRecord = scoreRecord;
        }
        
        public void Update()
        {
            List<int> record = scoreRecord.GetScoreRecord();
            DisplayScores(record);
        }

        private void DisplayScores(List<int> record)
        {
            int min = record.Min();
            int max = record.Max();
            Console.WriteLine("Min: " + min + ", Max: " + max);
        }
    }
}