using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value: ");
            string s1 = Console.ReadLine();
            int value1;

            while (int.TryParse(s1, out value1) == false)
            {
                Console.WriteLine("Cannot parse entry");
                Console.Write("Please enter a value: ");
                s1 = Console.ReadLine();
            }
            
            
            Console.Write("Please enter a second value: ");
            string s2 = Console.ReadLine();
            int value2;
            while (int.TryParse(s2, out value2) == false)
            {
                Console.WriteLine("Cannot parse entry");
                Console.Write("Please enter a value: ");
                s2 = Console.ReadLine();
            }

            Console.Write("(a)dd, (s)ubtract, (m)ultiply, (d)ivide: ");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "a":
                    Console.WriteLine("add");
                    Console.WriteLine("Total: " + Add(value1, value2));
                    break;
                case "s":
                    Console.WriteLine("subtract");
                    Console.WriteLine("Total: " + Subtract(value1, value2));
                    break;
                case "m":
                    Console.WriteLine("multiply");
                    Console.WriteLine("Total: " + Multiply(value1, value2));
                    break;
                case "d":
                    Console.WriteLine("divide");
                    Console.WriteLine("Total: " + Divide(value1, value2));
                    break;
                default:
                    Console.WriteLine("try harder next time");
                    break;
            }

        }
        
        static int Add(int val1, int val2)
        {
            return val1 + val2;
        }
        static int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
        static int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }
        static int Divide(int val1, int val2)
        {
            return val1 / val2;
        }
    }
}
