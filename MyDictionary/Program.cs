using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> people = new  MyDictionary<int, string>();
            
            people.Add (1, "Gökçe");
            people.Add (2, "Burak");
            people.Add(3, "Gözde");
            people.Add(4, "Rüzgar");

            
           people.List();

        }
    }
    
}
