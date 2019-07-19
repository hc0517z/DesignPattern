using System;

namespace DesignPattern.TemplateMethod
{
    public class AutomaticOperationCar : Car
    {
        protected override void Play()
        {
            Console.WriteLine("Drive D에 기어 놓기");
            Console.WriteLine("자동 기어 변속");
        }

        protected override void RunSomething()
        {
            Console.WriteLine("스무스하게 ~ 브레이크 ~ !!");
        }
    }
}