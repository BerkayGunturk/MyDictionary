using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] age;
        T2[] name;
        public MyDictionary()
        {
            age = new T1[0];
            name = new T2[0];
        }
        public void Add(T1 ages, T2 names)
        {
            T1[] tempAge = age;
            T2[] tempName = name;

            age = new T1[age.Length + 1];
            name = new T2[name.Length + 1];

            for (int i = 0; i < tempAge.Length; i++)
            {
                age[i] = tempAge[i];
            }
            age[age.Length - 1] = ages;

            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }
            name[name.Length - 1] = names;



        }
        public void ToList()
        {
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Yaş: " + age[i] + " " + "İsim: " + name[i]);


            }
        }
    }
}
