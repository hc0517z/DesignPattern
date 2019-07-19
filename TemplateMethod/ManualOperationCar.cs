using System;

namespace DesignPattern.TemplateMethod
{
    public class ManualOperationCar : Car
    {
        protected override void Play()
        {
            Console.WriteLine("클러치한 상태에서 2단 넣기");
            Console.WriteLine("기어 수동 조작");
        }

        protected override void RunSomething()
        {
            Console.WriteLine("뻑뻑하게ㅠㅠ 브레이크 ~ !!");
        }
    }
}