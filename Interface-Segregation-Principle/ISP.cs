// No client should be forced to depend on methods it does not use

using System;

class ISP
{
    public interface IBird
    {
        void Eat();
    }

    public interface IFlyable : IBird
    {
        void Fly();
    }

    public interface ISwimmable : IBird
    {
        void Swim();
    }

    public class Parrot : IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Parrot Eat");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot Fly");
        }
    }

    public class Penguin : ISwimmable
    {
        public void Eat()
        {
            Console.WriteLine("Penguin Eat");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin Swim");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFlyable flyingBird = new Parrot();
            flyingBird.Fly();
            ISwimmable swimmingBird = new Penguin();
            swimmingBird.Swim();
        }
    }    
}