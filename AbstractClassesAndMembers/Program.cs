using System;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int With { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
    }

   public interface Shape1
    {
        public int With { get; set; }
        public int Height { get; set; }

       
    }
    
    public class Circle : Shape, Shape1
    {
        public override void Draw()
        {
            
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}