using System;
using System.Collections;
using System.Collections.Generic;

namespace hastTable
{
    class Program
    {
        //hastTable.add("key","value")
        static void Main(string[] args)
        {
           
            dictionary d = new dictionary();
            d.show();
            Console.WriteLine("***********************");
            Hashtable ht = new Hashtable();
            ht.Add("1", "mani");
            ht.Add("2", "honey");
            ht.Add("3", "puri");
            ht.Add("4", "shilpa");
            ht.Add("5", "koti");
            ht.Add("6", "roti");
            ICollection keys = ht.Keys;
            foreach (var k in keys )
            {
                Console.WriteLine(ht[k]);
            }
            ht.Remove("3");
            ht.Remove("4");
            Console.WriteLine("***********after removing elements***********");
           
           
            foreach (string k in keys)
            {
                Console.WriteLine(ht[k]);
            }

        
        }
    }
}
class dictionary
{
    public void show()
    {
        Dictionary<string, string> empList = new Dictionary<string, string>();
        empList.Add("prakash","employee");
        empList.Add("amith", "softwareDeveloper");
        empList.Add("fisal", "senior employee");
        empList.Add("mani", "analyst");
        empList.Add("puri", "teacher");
        empList.Add("sowji", "maneger");
        foreach (KeyValuePair<string, string> author in empList)
        {
            Console.WriteLine("Key: {0}, Value: {1}", author.Key,author.Value);
        }
        Console.WriteLine("*****************************");

        Dictionary<string, int> AuthorList = new Dictionary<string, int>();
        AuthorList.Add("prakash", 24);
        AuthorList.Add("ravi", 65);
        AuthorList.Add("mani", 45);
        AuthorList.Add("puri", 54);
        foreach (KeyValuePair<string, int> author in AuthorList)
        {
            Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
        }
        Console.WriteLine("**********************************");

        Dictionary<string, float> priceList = new Dictionary<string, float>();
        priceList.Add("prakash", 24.4f);
        priceList.Add("mani", 54.6f);
        priceList.Add("puri",45.6f);
        Console.WriteLine("****************************");

        foreach (KeyValuePair<string, float> author in priceList)
        {
            Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
        }
        Console.WriteLine("***************************");
        priceList.Remove("prakash");
        Console.WriteLine("New list after removing an item: ");
        foreach (KeyValuePair<string, float> car in priceList)
        {
            Console.WriteLine("Key: {0}, Value: {1}", car.Key, car.Value);
        }
    }
}
