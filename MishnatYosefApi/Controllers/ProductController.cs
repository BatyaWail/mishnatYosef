using Microsoft.AspNetCore.Mvc;
using MishnatYosefApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MishnatYosefApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _data;
        public ProductController(DataContext data)
        {
            _data = data;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _data.products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Product temp= _data.products.Find(x => x.Id == id);
            if (temp == null)
                return NotFound();
            return Ok( temp);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _data.products.Add(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product value)
        {
            //products[products.FindIndex(x => x.Id == id)] = value;
            int x = _data.products.FindIndex(x => x.Id == id);
            if (x<0)
                return NotFound();
            _data.products[x] = value;
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _data.products.Remove(_data.products.Find(x => x.Id == id));
        }
    }
}
