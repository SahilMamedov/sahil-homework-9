using System;
using task_9.Models;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur
                       Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
                       Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
                       Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

                       Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
                       Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
                       Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

                       Program class-ında bir menu olacaq
                       1. Square
                       2. Rectangular
                       0. Quit

                       İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
                       İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
                       İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.

           */


            while (true)
            {
                Console.WriteLine("----------");
                Console.WriteLine("1: Square");
                Console.WriteLine("2: Rectangular");
                Console.WriteLine("0: Quit");

                string variant = Console.ReadLine();
                if (variant == "1")
                {
                    Console.WriteLine("Enter the Side");
                    //  int side = Convert.ToInt32(Console.ReadLine());
                    // Square square = new Square(side);
                    Square square = new Square();
                    square.Side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Result: {square.CalcArea()}");
                }

                else if (variant == "2")
                {
                    Console.WriteLine("Enter the width of the rectangular");
                    //  int width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Length of the rectangular");
                    // int length = Convert.ToInt32(Console.ReadLine());
                    // Rectangular rectangular = new Rectangular(width, length);
                    Rectangular rectangular = new Rectangular();
                    rectangular.Width = Convert.ToInt32(Console.ReadLine());
                    rectangular.Length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Result: {rectangular.CalcArea()}"); 
                }
                else if (variant == "0")
                {
                    Console.WriteLine("Thanks Application closed");
                    return;
                }

            }
        }
    }
}
