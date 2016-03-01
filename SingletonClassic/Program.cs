using System;

namespace SingletonClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.Instance.DoSomething("t1");
            SingletonClass.Instance.DoSomething("t2");
            Console.ReadKey();
        }
    }
}
