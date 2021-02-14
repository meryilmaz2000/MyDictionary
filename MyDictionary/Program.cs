using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(333, "Burak");
            myDictionary.Add(639, "Hasan");
            myDictionary.Add(412, "Seda");
            myDictionary.Add(1024, "Sinan");

            myDictionary._Print();

            Console.WriteLine("Key sayısı : " + myDictionary._KeyCount);
            Console.WriteLine("Value Sayısı : " + myDictionary._ValueCount);

            myDictionary.Clear(); //Sözlüğü siler.
            Console.WriteLine("\n ***Clear Metodundan Sonra \n");

            Console.WriteLine("Key sayısı : " + myDictionary._KeyCount);
            Console.WriteLine("Value Sayısı : " + myDictionary._ValueCount);
            Console.WriteLine("\n");
            myDictionary._Print();

        }
    }
}
