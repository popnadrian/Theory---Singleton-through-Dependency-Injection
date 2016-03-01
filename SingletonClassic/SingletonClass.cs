using System;

namespace SingletonClassic
{
    class SingletonClass
    {
        private SingletonClass()
        {
        }

        public void DoSomething(string input)
        {
            Console.WriteLine("DoSomething - {0}", input);
        }


        static SingletonClass _instance = new SingletonClass();
        public static SingletonClass Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
