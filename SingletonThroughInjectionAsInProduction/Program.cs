using Ninject;
using System;

namespace SingletonThroughInjectionAsInProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * In this example the singleton character of the SingletonClass is implemented through Ninject dependency container
            * and it is well illustrated by the usage of the Service for which I get multiple instances (see the identifier field in both the singleton class and the service)
            */
            var kernel = new StandardKernel();
            kernel.Bind<ISingletonClass>().To<SingletonClass>().InSingletonScope();


            kernel.Get<Service>().DoSomething("t1");
            kernel.Get<Service>().DoSomething("t2");
            kernel.Get<Service>().DoSomething("t3");
            kernel.Get<Service>().DoSomething("t4");
            Console.ReadKey();
        }
    }
}
