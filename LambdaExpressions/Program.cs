using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // numbner => numbner * numbner
            
            // () => ...
            // x => ...
            // (x, y, z) => ...
            
            // Func<int, int> square = number => number * number;
            // int Square(int number) => number * number;
            // Console.WriteLine(square(5));
            //
            // const int factor = 5;
            // int multipier(int n) => n * factor;
            // Func<int, int> Multipier = n => n * factor;
            //
            // var result = Multipier(10);
            // Console.WriteLine(result);
         //*************
         
         var books = new BookRepository().GetBooks();
         // var cheapBooks = books.FindAll(IsCheaperThanTenDoalrs);
         var cheapBooks = books.FindAll(book => book.Price < 10);

         foreach (var VARIABLE in cheapBooks)
         {
             Console.WriteLine(VARIABLE.Title);
         }

        }

        // static bool IsCheaperThanTenDoalrs(Book book)
        // {
        //     return book.Price < 10;
        // }

        // static int Square(int number)
        // {
        //     return number * number;
        // }
    }
}