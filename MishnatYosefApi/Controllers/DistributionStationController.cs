using Microsoft.AspNetCore.Mvc;
using MishnatYosefApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosefApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionStationController : ControllerBase
    {
        static List<DistributionStation> distributionStations = new List<DistributionStation>()
        {
            new DistributionStation(0,"breslev 11-9 bb",30,DayOfWeek.Tuesday),
            new DistributionStation(1,"tifrach",10,DayOfWeek.Saturday),
            new DistributionStation(2,"AAAA",40,DayOfWeek.Monday),
        };
        // GET: api/<DistributionStation>
        [HttpGet]
        public IEnumerable<DistributionStation> GetList()
        {
            return distributionStations;
        }

        // GET api/<DistributionStation>/5
        [HttpGet("{id}")]
        public DistributionStation GetValue(int id)
        {
            return distributionStations.Find(x => x.Id == id);
        }
        [HttpGet("{day}/days")]
        public IEnumerable<DistributionStation> GetByDay(DayOfWeek day)
        {
            return distributionStations.FindAll(x => x.Day == day);
        }

        // POST api/<DistributionStation>
        [HttpPost]
        public void Post([FromBody] DistributionStation value)
        {
            distributionStations.Add(value);
        }

        // PUT api/<DistributionStation>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DistributionStation value)
        {
            distributionStations[distributionStations
                .FindIndex(x=>x.Id == id)] = value;
        }

        // DELETE api/<DistributionStation>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            distributionStations.Remove(distributionStations.Find(x => x.Id == id));
        }
    }
}
