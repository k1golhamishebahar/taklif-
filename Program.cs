using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usernum;
            string number;
            number = Console.ReadLine();
            usernum = int.Parse(number);
            Console.WriteLine(f(usernum));
            Console.ReadLine();
        }
    static int f(int x)
        {
            return x * x;           
        } 
    static int fib(int i)
        {
            if (i == 1)
                return 0;
            else if (i == 2)
                return 1;
            else 
                return fib(i - 1) + fib(i - 2);
        }        
    }
}
