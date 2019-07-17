using System;

namespace DesignPattern.Observer
{
    public class Client : ITest
    {
        public void Run()
        {
            Console.WriteLine("\n");
            Console.WriteLine("[ Run Observer Pattern Test Client ]");
            
            ScoreRecord scoreRecord = new ScoreRecord();
            
            DataSheetView dataSheetView = new DataSheetView(scoreRecord, 3);
            MinMaxView minMaxView = new MinMaxView(scoreRecord);
            
            scoreRecord.Attach(dataSheetView);
            scoreRecord.Attach(minMaxView);

            for (int index = 1; index <= 5 ; index++)
            {
                int score = index * 10;
                Console.WriteLine("Adding " + score);
                scoreRecord.AddScore(score);
            }
        }
    }
}