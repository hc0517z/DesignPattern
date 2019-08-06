using System;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public class DataSheetView : IObserver
    {
        private readonly ScoreRecord scoreRecord;
        private readonly int viewCount;

        public DataSheetView(ScoreRecord scoreRecord, int viewCount)
        {
            this.scoreRecord = scoreRecord;
            this.viewCount = viewCount;
        }

        public void Update()
        {
            var record = scoreRecord.GetScoreRecord();
            DisplayScore(record, viewCount);
        }

        private void DisplayScore(List<int> record, int viewCount)
        {
            Console.Write("List of " + viewCount + " entries: ");
            for (var i = 0; i < viewCount && i < record.Count; i++) Console.Write(record[i] + " ");
            Console.WriteLine();
        }
    }
}