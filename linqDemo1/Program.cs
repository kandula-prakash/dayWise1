using System;
using System.Collections.Generic;
using System.Linq;

namespace linqDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int>intList  = new List<int>() { 13, 56, 4, 5, 8, 4, 2, 5, 45, 65, 89, 2, 5, 4, 6, 9, 8, 7, 45 };
            List<string> strList = new List<string>()
         { "One","Two", "Three", "Four", "Five","Six" };
            Console.WriteLine("Skips the first three elemts from integer list");
            var firstList = intList.Skip(3);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("SkipsWhile method (Length < 4) by string list");
            var secondList = strList.SkipWhile(s => s.Length < 4);
            foreach (string str in secondList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Takes the first three elements from integer list");
            var thirdList = intList.Take(3);
            foreach (var item in thirdList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("TakeWhile method (Length < 4) by string list");
            var fourthList = strList.TakeWhile(s => s.Length < 4);
            foreach (string str in fourthList)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
    

