using System;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public class DataSheetView : IObserver
    {
        private ScoreRecord scoreRecord;
        private int viewCount;

        public DataSheetView(ScoreRecord scoreRecord, int viewCount)
        {
            this.scoreRecord = scoreRecord;
            this.viewCount = viewCount;
        }
        
        public void Update()
        {
            List<int> record = scoreRecord.GetScoreRecord();
            DisplayScore(record, viewCount);
        }

        private void DisplayScore(List<int> record, int viewCount)
        {
            Console.Write("List of " + viewCount + " entries: ");
            for (int i = 0; i < viewCount && i < record.Count; i++)
            {
                Console.Write(record[i] + " ");
            }
            Console.WriteLine();
        }
    }
}