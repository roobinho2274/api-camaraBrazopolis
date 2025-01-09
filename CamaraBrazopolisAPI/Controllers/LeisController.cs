using AutoMapper;

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
        private IMapper _mapper;

        public LeisController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<ReadLeisDTO> Get()
        {
            return _mapper.Map<List<ReadLeisDTO>>(_context.leis.ToList());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] List<InsereLeisDTO> leisDto)
        {
            leisDto.ToList().ForEach(n =>
            {
                var leis = _mapper.Map<Leis>(n);
                _context.leis.Add(leis);
                _context.SaveChanges();
            });
            return NoContent();
        }

        //// PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateLeiDTO leiDto)
        {
            var lei = _context.leis.FirstOrDefault(n => n.Id == id);
            if (lei == null)
            {
                return NotFound();
            }
            _mapper.Map(leiDto, lei);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var lei = _context.leis.FirstOrDefault(lei => lei.Id == id);
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
