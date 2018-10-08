using CandleShopApp.Core.ApplicationService.Implementation;
using CandleShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CandleShopApp.Core.ApplicationService.Services
{
    public class CandleService : ICandleService
    {
        readonly ICandlesRepository _CandlesRepo;

        public CandleService(ICandlesRepository candlesRepository)
        {
            _CandlesRepo = candlesRepository;
        }
        public Candles CreateCandle(string name, string color, string scent,double price)
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
        public Candles SaveCandle(Candles candle)
        {
            return _CandlesRepo.Create(candle);
        }

        public Candles DeleteCandle(int id)
        {
            return _CandlesRepo.DeleteCandle(id);
        }

        public List<Candles> ReadAllCandles()
        {
            return _CandlesRepo.ReadAll().ToList();
        }



        public Candles SearchById(int id)
        {
            return _CandlesRepo.ReadID(id);
        }

        public List<Candles> SearchCandlesByScent(string Scents)
        {
            var list = _CandlesRepo.ReadAll();
            var queryContinued = list.Where(candle => candle.Scent.Equals(Scents));
            queryContinued.OrderBy(candle => candle.Scent);
            return queryContinued.ToList();
        }

        public Candles UpdateCandle(Candles candleUpdate)
        {

            var candle = SearchById(candleUpdate.ID);
            candle.Name = candleUpdate.Name;
            candle.Scent = candleUpdate.Scent;
            candle.Color = candleUpdate.Color;
            candle.Price = candleUpdate.Price;
            
            return candle;
        }

     
    }
}
