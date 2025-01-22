using AutoMapper;

using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Data.ProjetoExecutivo;
using CamaraBrazopolisAPI.Data.VereadoresDTO;
using CamaraBrazopolisAPI.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamaraBrazopolisAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjetosExecutivoController : ControllerBase
{
    private ApplicationDbContext _context;
    private IMapper _mapper;

    public ProjetosExecutivoController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/<ProjetosExecutivoController>
    [HttpGet]
    public IEnumerable<ReadProjetosExecutivosDTO> BuscaProjetosExecutivo()
    {
        return _mapper.Map<List<ReadProjetosExecutivosDTO>>(_context.projeto_executivo.ToList());
    }

    // GET api/<ProjetosExecutivoController>/5
    [HttpGet("{id}")]
    public IActionResult BuscaProjetoExecutivo(int id)
    {
        var projeto = _context.projeto_executivo.FirstOrDefault(n => n.id == id);
        if (projeto == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<ReadProjetosExecutivosDTO>(projeto));
    }

    // POST api/<ProjetosExecutivoController>
    [HttpPost]
    public IActionResult InsereProjetoExecutivo([FromBody] List<InsertProjetosExecutivosDTO> projetoDTO)
    {
        projetoDTO.ToList().ForEach(n =>
        {
            var projeto = _mapper.Map<projeto_executivo>(n);
            _context.projeto_executivo.Add(projeto);
            _context.SaveChanges();
        });
        return NoContent();
    }

    // PUT api/<ProjetosExecutivoController>/5
    [HttpPut("{id}")]
    public IActionResult AtualizaProjetoExecutivo(int id, [FromBody] UpdateProjetosExecutivosDTO projetoDTO)
    {
        var projeto = _context.projeto_executivo.FirstOrDefault(n => n.id == id);
        if (projeto == null)
        {
            return NotFound();
        }
        _mapper.Map(projetoDTO, projeto);
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE api/<ProjetosExecutivoController>/5
    [HttpDelete("{id}")]
    public IActionResult DeleteProjeto(int id)
    {
        var projeto = _context.projeto_executivo.FirstOrDefault(projeto => projeto.id == id);
        if (projeto == null)
        {
            return NotFound();
        }
        _context.Remove(projeto);
        _context.SaveChanges();
        return NoContent();
    }
}
