using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();

            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();
        }
    }
}
