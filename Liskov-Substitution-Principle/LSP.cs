// Object of a superclass should be replaceable with object of a subclass
// without breaking the application 

using System;

class LSP
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

    public class Parrot : IBird, IFlyable
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

    public class Penguin : IBird, ISwimmable
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
            IBird parrot = new Parrot();
            parrot.Eat();
            Penguin penguin = new Penguin();
            penguin.Swim();
        }
    }    
}
