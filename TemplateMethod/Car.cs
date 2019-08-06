using System;

namespace DesignPattern.TemplateMethod
{
    public abstract class Car
    {
        public void PlayWithOwner()
        {
            Console.WriteLine("시동 켜기");
            Console.WriteLine("사이드 브레이크 해제");

            Play();
            RunSomething();
        }

        protected abstract void Play();

        protected abstract void RunSomething();
    }
}