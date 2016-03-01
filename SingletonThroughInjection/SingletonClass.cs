using System;

namespace SingletonThroughInjection
{
    class SingletonClass
    {
        static int _numberOfInstances = 0;

        readonly int _instanceId;

        public SingletonClass()
        {
            _instanceId = ++_numberOfInstances;
        }

        public void DoSomething(string input)
        {
            Console.WriteLine("{0} is Doing something - {1}", _instanceId, input);
        }
    }
}
