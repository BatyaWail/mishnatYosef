using Microsoft.AspNetCore.Mvc;
using MishnatYosefApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosefApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _data;
        public ClientController(DataContext data)
        {
            _data = data;
        }
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> GetList()
        {
            return _data.clients;
        }
        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client GetValue(int id)
        {
            return _data.clients.Find(x=>x.Id==id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            _data.clients.Add(value);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
            int i=_data.clients.FindIndex(x=>x.Id == id);
            _data.clients[i]=value;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _data.clients.Remove(_data.clients.Find(x=>x.Id==id));
        }
    }
}
