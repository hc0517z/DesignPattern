using System;

namespace DesignPattern.Observer
{
    public class Client : ITest
    {
        public void Run()
        {
            var scoreRecord = new ScoreRecord();

            var dataSheetView = new DataSheetView(scoreRecord, 3);
            var minMaxView = new MinMaxView(scoreRecord);

            scoreRecord.Attach(dataSheetView);
            scoreRecord.Attach(minMaxView);

            for (var index = 1; index <= 5; index++)
            {
                var score = index * 10;
                Console.WriteLine("Adding " + score);
                scoreRecord.AddScore(score);
            }
        }
    }
}