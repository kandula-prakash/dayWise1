using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
             method m = new method();
             m.demo();
            stringHelper sd = new stringHelper();
            sd.demo1();

            string s;
            Console.WriteLine("enter the string:");
            s = Console.ReadLine();
           s = stringReverse(s);
            Console.WriteLine("reverse String:");


            Console.WriteLine(s);
            Console.ReadLine();
        }
        public static string stringReverse(string s)
        {
            if (s.Length > 0)
            {
                return s[s.Length - 1] + stringReverse(s.Substring(0, s.Length - 1));
            }
            else
            {
                return s;
            }


        }



    }
}





