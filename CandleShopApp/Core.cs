using System;
using System.Collections.Generic;
using System.Text;

namespace CandleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICandlesRepository, CandlesRepository>();
            serviceCollection.AddScoped<ICandlesService, CandlesService>();


            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            FakeDB.InitData();
            printer.MakeMenu();
        }
    }
}
