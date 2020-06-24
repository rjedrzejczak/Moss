using System;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            shape.Height = 3;
            text.Height = 2;
            
            Console.WriteLine(shape.Height);
            
            Console.WriteLine("Hello World!");
        }
    }
}