using CandleShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandleShopApp.Core.ApplicationService.Implementation
{
    public interface ICandleService
    {
        Candles CreateCandle(string Name, string Color, string Scent, double Price);
        Candles SaveCandle(Candles candle);
        Candles UpdateCandle(Candles candleUpdate);
        List<Candles> ReadAllCandles();
        Candles SearchById(int id);
        Candles DeleteCandle(int id);
        

    }
}
