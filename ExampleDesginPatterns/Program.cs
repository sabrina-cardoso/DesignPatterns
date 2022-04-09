using System;

namespace ExampleDesginPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSingleton();
            TestfactoryMethod();
            Console.ReadLine();
        }


        static void TestSingleton(){
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();


            if (s1 == s2)
                Console.WriteLine("Singleton works, both variables contain the same instance.");

            else
                Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        static void TestfactoryMethod()
        {

        }
    }
}
