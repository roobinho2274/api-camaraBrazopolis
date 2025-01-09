using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CamaraBrazopolisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeisController : ControllerBase
    {
        private ApplicationDbContext _context;

        public LeisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<leis> Get()
        {
            return _context.leis.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] List<leis> value)
        {
            value.ToList().ForEach(n =>
            {
                _context.leis.Add(n);
                _context.SaveChanges();
            });
            return NoContent();
        }

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var lei = _context.leis.FirstOrDefault(lei => lei.id == id);
            if (lei == null)
            {
                return NotFound();
            }
            _context.Remove(lei);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
