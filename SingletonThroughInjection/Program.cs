using Ninject;
using System;

namespace SingletonThroughInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<SingletonClass>().To<SingletonClass>().InSingletonScope();


            kernel.Get<SingletonClass>().DoSomething("t1");
            kernel.Get<SingletonClass>().DoSomething("t2");
            kernel.Get<SingletonClass>().DoSomething("t3");
            kernel.Get<SingletonClass>().DoSomething("t4");
            Console.ReadKey();
        }
    }
}
