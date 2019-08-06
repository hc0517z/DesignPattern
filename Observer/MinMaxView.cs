using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Observer
{
    public class MinMaxView : IObserver
    {
        private readonly ScoreRecord scoreRecord;

        public MinMaxView(ScoreRecord scoreRecord)
        {
            this.scoreRecord = scoreRecord;
        }

        public void Update()
        {
            var record = scoreRecord.GetScoreRecord();
            DisplayScores(record);
        }

        private void DisplayScores(List<int> record)
        {
            var min = record.Min();
            var max = record.Max();
            Console.WriteLine("Min: " + min + ", Max: " + max);
        }
    }
}