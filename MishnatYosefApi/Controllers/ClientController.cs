using Microsoft.AspNetCore.Mvc;
using MishnatYosefApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosefApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        static List<Client> clients = new List<Client>()
        {
            new Client(0,"batya wail","0504119712","breslev 18 bney brak"),
            new Client(1,"yeudit cohen","0504116146","chagai 3 bney brak"),
            new Client(2,"batya","0504119785","ezra 5 bney brak"),
            new Client(3,"wais yosi","035702504","tifrach")
        };
        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> GetList()
        {
            return clients;
        }
        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client GetValue(int id)
        {
            return clients.Find(x=>x.Id==id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            clients.Add(value);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
            int i=clients.FindIndex(x=>x.Id == id);
            clients[i]=value;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clients.Remove(clients.Find(x=>x.Id==id));
        }
    }
}
