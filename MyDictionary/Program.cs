using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(06,"Ankara");
            cities.Add(35,"İzmir");
            cities.Add(34,"İstanbul");

            cities.GetAll();
        }
    }
}
