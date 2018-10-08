using CandleShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using CandleShopApp.Core.Entity;
using CandleShopApp.Core.ApplicationService.Implementation;

namespace CandleShopApp
{
    public class Printer : IPrinter
    {
        readonly ICandleService _CandleService;

        public Printer(ICandleService CandleService)
        {
            _CandleService = CandleService;
            Console.SetWindowSize(130, 44);
            Console.WriteLine("Candles shop \n  Write the shown number for selection  \n____1: Display all available pets \n____2: Search pets by type \n____3: Create a new candle \n____4: Delete a candle \n____5: Update a pet \n____6: Sort pets by price from lowest \n____7: Get 5 cheapest available pets");
            Console.ReadLine();
            MakeMenu();
        }


        public void MakeMenu()
        {

            Console.WriteLine("\n____1: Display all available pets \n____2: Delete a pet \n____3: Create a new pet \n____4: Search by type \n____5: Update a pet \n____6: Sort pets by price from lowest \n____7: Get 5 cheapest available pets");

            var selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:

                    PrintList(_CandleService.ReadAllCandles());
                    MakeMenu();
                    break;
                case 2:
                    int idForDelete = PrintFindCandleById();
                    _CandleService.DeleteCandle(idForDelete);
                    break;

                case 3:
                    var name = Question("name: ");
                    var color = Question("color: ");
                    var scent = Question("type: ");
                    var price = Question1("price: ");
                    var candle = _CandleService.CreateCandle(name, color, scent, price);
                    _CandleService.SaveCandle(candle);
                    MakeMenu();
                    break;

                case 4:

                    Console.WriteLine("Enter scent to look for: ");
                    var search = Console.ReadLine();
                    var candlesByType = _CandleService.SearchCandlesByScent(search);

                    Console.ReadLine();
                    Console.Clear();
                    break;


                case 5:
                    var idEdit = PrintFindCandleById();
                    var candleEdit = _CandleService.SearchById(idEdit);

                    var newName = Question("Name of Pet:");
                    var newColor = Question("Color:");
                    var newScent = Question("Scent:");
                   
                    var newPrice = Question1("Price:");

                    _CandleService.UpdateCandle(new Candles()
                    {
                        ID = idEdit,
                        Name = newName,
                        Color = newColor,
                        Scent = newScent,
                        Price = newPrice,
                    });


                    Console.WriteLine("Edit Done");
                    Console.ReadLine();

                    break;
                    UpdateCandle();
                    MakeMenu();
                    break;



            }


        }



        string Question(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        double Question1(string question)
        {
            Console.WriteLine(question);
            return Convert.ToDouble(Console.ReadLine());
        }
        DateTime Question3(string question)
        {
            Console.WriteLine(question);
            return Convert.ToDateTime(Console.ReadLine());
        }


        Candles CreateCandle(string name, string color, string scent,double price)
        {

            var candle = new Candles()
            {
                Name = name,
                Color = color,
                Scent = scent,
                Price = price,
            };
            return candle;

        }



        void UpdateCandle()
        {
            var id = PrintFindCandleById();
            var candle = _CandleService.SearchById(id);
            Console.WriteLine("Name: ");
            candle.Name = Console.ReadLine();
            Console.WriteLine("Scent: ");
            candle.Scent = Console.ReadLine();
            Console.WriteLine("Color: ");
            candle.Color = Console.ReadLine();
            Console.WriteLine("Price: ");
            candle.Price = Convert.ToDouble(Console.ReadLine());
            
        }



        void PrintList(List<Candles> CandlesList)
        {
            Console.WriteLine("\nList of Candles");
            foreach (var candle in CandlesList)
            {
                Console.WriteLine($"\nId: {candle.ID} " +
                $"\nName: {candle.Name} " +
                $"Scents: {candle.Scent} " +
                $"\nColor: {candle.Color} " +
                $"\nPrice: {candle.Price} ");
            }
            Console.WriteLine("\n");
        }


        int PrintFindCandleById()
        {
            int id;
            Console.WriteLine("Insert Id:");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Insert valid Id");
            }
            return id;
        }


    }
}
