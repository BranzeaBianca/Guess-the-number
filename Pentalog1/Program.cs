using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentalog1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int r = rng.Next(0, 100);

            Console.WriteLine("This game is called guess the number. I will pick a number between 0 and 100 and you have to guess it so let's begin. ");
            Console.WriteLine("What number do I have in mind (I should better call it memory :)) )?");

            int x = -1;

            while (x !=  r)
            {
                x = int.Parse(Console.ReadLine());
                if (x < r)
                    Console.WriteLine("The number you suggested is too small. Try a bigger one!");
                else if (x > r)
                    Console.WriteLine("the number you suggested is too big. Try a smaller one!");
            }

            Console.WriteLine("Uhuuu, you are right, the number was " + x);
            
        }
    }
}
