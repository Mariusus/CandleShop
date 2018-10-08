using System;
using System.Collections.Generic;
using System.Text;

namespace CandleShopApp.Core.Entity
{
    public interface ICandlesRepository
    {
        Candles Create(Candles candle);

        Candles ReadID(int ID);

        IEnumerable<Candles> ReadAll();

        Candles UpdateCandle(Candles candleUpdate);

        Candles DeleteCandle(int ID);


    }
}
