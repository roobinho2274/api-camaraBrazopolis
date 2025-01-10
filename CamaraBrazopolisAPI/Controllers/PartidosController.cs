using AutoMapper;

using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Data.PartidosDTO;
using CamaraBrazopolisAPI.Models;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamaraBrazopolisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidosController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public PartidosController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<PartidosController>
        [HttpGet]
        public IEnumerable<ReadPartidoDTO> Get()
        {
            return _mapper.Map<List<ReadPartidoDTO>>(_context.partidos.ToList());
        }

        // GET api/<PartidosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var partido = _context.partidos.FirstOrDefault(n => n.Id == id);
            if (partido == null)
            {

                return NotFound();
            }
            return Ok(_mapper.Map<ReadPartidoDTO>(partido));
        }

        // POST api/<PartidosController>
        [HttpPost]
        public IActionResult Post([FromBody] List<InsertPartidoDTO> partidoDto)
        {
            partidoDto.ToList().ForEach(n =>
            {
                var partidos = _mapper.Map<partidos>(n);
                _context.partidos.Add(partidos);
                _context.SaveChanges();
            });
            return NoContent();
        }

        // PUT api/<PartidosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdatePartidoDTO partidoDto)
        {
            var partido = _context.leis.FirstOrDefault(n => n.Id == id);
            if (partido == null)
            {
                return NotFound();
            }
            _mapper.Map(partidoDto, partido);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/<PartidosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var partido = _context.leis.FirstOrDefault(partido => partido.Id == id);
            if (partido == null)
            {
                return NotFound();
            }
            _context.Remove(partido);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
