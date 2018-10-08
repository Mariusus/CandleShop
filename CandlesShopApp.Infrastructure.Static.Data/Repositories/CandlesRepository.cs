using CandleShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandlesShopApp.Infrastructure.Static.Data.Repositories
{
    public class CandlesRepository : ICandlesRepository
    {
        static int id = 1;
        List<Candles> _CandlesList = FakeDB._CandlesList;

        public CandlesRepository()
        {
            FakeDB.InitData();
        }
        public Candles Create(Candles candle)
        {
            candle.ID = id++;
            _CandlesList.Add(candle);
            return candle;
        }



        public Candles DeleteCandle(int ID)
        {
            var candleFound = this.ReadID(ID);
            if (candleFound != null)
            {
                _CandlesList.Remove(candleFound);
            }
            return null;
        }

        public IEnumerable<Candles> ReadAll()
        {
            return _CandlesList;
        }

        public Candles ReadID(int ID)
        {
            foreach (var candle in _CandlesList)
            {

                if (candle.ID == id)
                {
                    return candle;
                }

            }
            return null;
        }

        public Candles UpdateCandle(Candles candleUpdate)
        {
            var candleDB = this.ReadID(candleUpdate.ID);
            if (candleDB != null)
            {
                candleDB.Name = candleUpdate.Name;
                candleDB.Scent = candleUpdate.Scent;
                candleDB.Color = candleUpdate.Color;
                candleDB.Price = candleUpdate.Price;
             
                return candleDB;


            }
            return null;
        }

    }
}
