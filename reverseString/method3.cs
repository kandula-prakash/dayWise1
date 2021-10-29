using System;
using System.Collections.Generic;
using System.Text;

namespace reverseString
{
   public  class stringHelper
    {
        public  string revreseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
    
          public  void demo1()
            {
                Console.WriteLine(revreseString("this"));
                Console.WriteLine(revreseString("is"));
                Console.WriteLine(revreseString("brp"));
                Console.WriteLine(revreseString("class"));
                Console.ReadLine();
            }

    }
    }

