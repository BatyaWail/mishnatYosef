using Microsoft.AspNetCore.Mvc;
using MishnatYosefApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosefApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionStationController : ControllerBase
    {
        private readonly DataContext _data;
        public DistributionStationController(DataContext data)
        {
            _data = data;
        }
        // GET: api/<DistributionStation>
        [HttpGet]
        public IEnumerable<DistributionStation> GetList()
        {
            return _data.distributionStations;
        }

        // GET api/<DistributionStation>/5
        [HttpGet("{id}")]
        public DistributionStation GetValue(int id)
        {
            return _data.distributionStations.Find(x => x.Id == id);
        }
        [HttpGet("{day}/days")]
        public IEnumerable<DistributionStation> GetByDay(DayOfWeek day)
        {
            return _data.distributionStations.FindAll(x => x.Day == day);
        }

        // POST api/<DistributionStation>
        [HttpPost]
        public void Post([FromBody] DistributionStation value)
        {
            _data.distributionStations.Add(value);
        }

        // PUT api/<DistributionStation>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DistributionStation value)
        {
            _data.distributionStations[_data.distributionStations
                .FindIndex(x=>x.Id == id)] = value;
        }

        // DELETE api/<DistributionStation>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _data.distributionStations.Remove(_data.distributionStations.Find(x => x.Id == id));
        }
    }
}
