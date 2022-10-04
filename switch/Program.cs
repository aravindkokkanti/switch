using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 13;

            switch(month)
            {
                case 1: Console.WriteLine("january");
                    break;
                case 2: Console.WriteLine("feb");
                    break;
                case 3: Console.WriteLine("march");
                    break;
                case 4: Console.WriteLine("april");
                    break;
                case 5: Console.WriteLine("may");
                    break;
                case 6: Console.WriteLine("june");
                    break;
                case 7:  Console.WriteLine("july");
                    break;
                case 8:  Console.WriteLine("august");
                    break;
                case 9:  Console.WriteLine("sept");
                    break;
                case 10: Console.WriteLine("oct");
                    break;
                case 11: Console.WriteLine("nov");
                    break;
                case 12: Console.WriteLine("dec");
                    break;
                default:
                    Console.WriteLine("ENTER VALID MONTH");
                    break;
                    
            }


            char name = 'd';
            switch(name)
            {
                case 'a':
                case 'r':
                case 'v':
                case 'i':
                case 'n':
                case 'd': Console.WriteLine("ARVIND");
                    break;
                default: Console.WriteLine("letternotmatched");
                    break;

            }
            



        }
    }
}
