using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice entered");
                        break;
                    }
            }
        }
    }
}