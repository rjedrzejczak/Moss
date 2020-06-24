using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var number = (int) list[1];
            
            Console.WriteLine("Hello World!");
        }
    }
}