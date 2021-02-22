using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customer = new MyDictionary<int, string>();

            customer.Add(22, "Hasan");
            customer.Add(50, "Bekir");
            customer.Add(45, "Hanife");
            customer.Add(18, "Mehmet");


            customer.ToList();
        }
    }
}