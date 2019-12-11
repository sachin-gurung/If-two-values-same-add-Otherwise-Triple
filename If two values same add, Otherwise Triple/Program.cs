using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.//
namespace If_two_values_same_add__Otherwise_Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input two integers//
            Console.WriteLine(test(1, 2));
            Console.WriteLine(test(3, 2));
            Console.WriteLine(test(2, 2));
            Console.ReadLine();
        }
        //Calculate. If two integers are same, then triple their sum. Otherwise just add.//
        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
/*
 Result
 3
5
12
 */
