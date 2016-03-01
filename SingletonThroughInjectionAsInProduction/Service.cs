using System;

namespace SingletonThroughInjectionAsInProduction
{
    class Service
    {
        static int _numberOfInstances = 0;

        readonly int _instanceId;
        readonly ISingletonClass _singleton;

        public Service(ISingletonClass singleton)
        {
            _singleton = singleton;
            _instanceId = ++_numberOfInstances;
        }

        public void DoSomething(string input)
        {
            Console.Write("Service {0};", _instanceId);
            _singleton.DoSomething(input);
        }
    }
}
