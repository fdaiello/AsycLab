using System;
using System.Threading.Tasks;

namespace AsycLab
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOneA();

            //var s = Console.ReadLine();
            //Console.WriteLine("The End");
        }
        public static async void Test3()
        {
            await Method4();
            await Method5();

        }
        public static async void Test2()
        {
            Method4();
            Method5();

        }
        public static async Task Method4()
        {
            await Task.Delay(3000);
            Console.WriteLine("Method 4 ended!");
        }
        public static async Task Method5()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method 5 ended!");
        }
        static void TestOne()
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        static void TestOneA()
        {
            Method1A();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }
        public static async Task Method1A()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" Method 1");
                // Do something
                await Task.Delay(100);
            }
        }

        public static async void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                await Task.Delay(100);
            }
        }
    }
}
