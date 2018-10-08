using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandleShopApp.Core.ApplicationService.Implementation;
using CandleShopApp.Core.ApplicationService.Services;
using CandleShopApp.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EASVCandlesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandlesController : ControllerBase
    {
        private readonly ICandleService _candlesService;

        public CandlesController(ICandleService candlesService)
        {
            _candlesService = candlesService;
        }


        // GET api/Pets
        [HttpGet]
        public ActionResult<IEnumerable<Candles>> Get()
        {
            return _candlesService.ReadAllCandles();
        }

        // GET api/Pets/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/Pets
        [HttpPost]
        public void Post([FromBody] Candles candle)
        {
            _candlesService.SaveCandle(candle);
        }

        // PUT api/Pets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Pets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
