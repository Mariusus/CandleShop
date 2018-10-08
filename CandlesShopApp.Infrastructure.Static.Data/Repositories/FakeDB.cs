using CandleShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandlesShopApp.Infrastructure.Static.Data.Repositories
{
    public static class FakeDB
    {
        public static int CandleID { get; set; }
        public static List<Candles> _CandlesList = new List<Candles>();

        public static void InitData()
        {
            CandleID = 0;
            Candles candle1 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };

            Candles candle2 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };


            Candles candle3 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };

            Candles candle4 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };


            Candles candle5 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };


            Candles candle6 = new Candles()
            {
                ID = CandleID++,
                Name = "Artemis",
                Color = "Blue",
                Scent = "Horse",
                Price = 22.22,
            };

            _CandlesList.Add(candle1);
            _CandlesList.Add(candle2);
            _CandlesList.Add(candle3);
            _CandlesList.Add(candle4);
            _CandlesList.Add(candle5);
            _CandlesList.Add(candle6);
        }

    }
}
