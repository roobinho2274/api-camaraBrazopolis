using AutoMapper;
using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Data.PartidosDTO;
using CamaraBrazopolisAPI.Data.VereadoresDTO;
using CamaraBrazopolisAPI.Models;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamaraBrazopolisAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VereadorController : ControllerBase
{
    private ApplicationDbContext _context;
    private IMapper _mapper;

    public VereadorController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<VereadorController>
    [HttpGet]
    public IEnumerable<ReadVereadorDTO> BuscaVereadores()
    {
        return _mapper.Map<List<ReadVereadorDTO>>(_context.vereadores.ToList());
    }

    // GET api/<VereadorController>/5
    [HttpGet("{id}")]
    public IActionResult BuscaVereador(int id)
    {
        var vereador = _context.vereadores.FirstOrDefault(n => n.id == id);
        if (vereador == null)
        {

            return NotFound();
        }
        return Ok(_mapper.Map<ReadVereadorDTO>(vereador));
    }

    // POST api/<VereadorController>
    [HttpPost]
    public IActionResult InsereVereador([FromBody] List<InsertVereadorDTO> vereadorDto)
    {
        vereadorDto.ToList().ForEach(n =>
        {
            var vereador = _mapper.Map<vereadores>(n);
            _context.vereadores.Add(vereador);
            _context.SaveChanges();
        });
        return NoContent();
    }

    // PUT api/<VereadorController>/5
    [HttpPut("{id}")]
    public IActionResult AtualizaVereador(int id, [FromBody] UpdateVereadorDTO vereadorDto)
    {
        var vereador = _context.vereadores.FirstOrDefault(n => n.id == id);
        if (vereador == null)
        {
            return NotFound();
        }
        _mapper.Map(vereadorDto, vereador);
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE api/<VereadorController>/5
    [HttpDelete("{id}")]
    public IActionResult DeleteVereador(int id)
    {
        var vereador = _context.vereadores.FirstOrDefault(vereador => vereador.id == id);
        if (vereador == null)
        {
            return NotFound();
        }
        _context.Remove(vereador);
        _context.SaveChanges();
        return NoContent();
    }
}
