using System;

namespace DesignPattern.Decorator
{
    public class Client : ITest
    {
        public void Run()
        {
            Display road = new RoadDisplay();
            road.Draw();
            Console.WriteLine();
            Display roadWithLane = new LaneDecorator(new RoadDisplay());
            roadWithLane.Draw();
            Console.WriteLine();
            Display roadWithTraffic = new TrafficDecorator(new RoadDisplay());
            roadWithTraffic.Draw();
            Console.WriteLine();
            Display roadWithLaneAndTraffic = new TrafficDecorator(new LaneDecorator(new RoadDisplay()));
            roadWithLaneAndTraffic.Draw();
            Console.WriteLine();
            Display roadWithLaneAndTrafficAndCrossing = new CrossingDecorator(new TrafficDecorator(new LaneDecorator(new RoadDisplay())));
            roadWithLaneAndTrafficAndCrossing.Draw();

//            Display road = new RoadDisplay();
//            road.Draw();
//            Console.WriteLine();
//            Display roadWithLane = new LaneDecorator(road);
//            roadWithLane.Draw();
//            Console.WriteLine();
//            Display roadWithTraffic = new TrafficDecorator(road);
//            roadWithTraffic.Draw();
//            Console.WriteLine();
//            Display roadWithLaneAndTraffic = new TrafficDecorator(roadWithLane);
//            roadWithLaneAndTraffic.Draw();
//            Console.WriteLine();
//            Display roadWithLaneAndTrafficAndCrossing = new CrossingDecorator(roadWithLaneAndTraffic);
//            roadWithLaneAndTrafficAndCrossing.Draw();
        }
    }
}