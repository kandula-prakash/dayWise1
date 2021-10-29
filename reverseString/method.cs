using System;
using System.Collections.Generic;
using System.Text;

namespace reverseString
{
    public class method
    {
       public  void demo()
        {

            Console.WriteLine(reverse("hello world"));
            Console.ReadLine();

        }
        public  string reverse(string s)
        {
            string reverseStr = "";
            for (int a = s.Length; a >= 0; a--)
            {
                reverseStr = reverseStr + s[a];
            }
            return reverseStr;
        }

    }
}
