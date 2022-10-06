using System.Linq;
using System.Collections.Generic;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        private static List<Produto> produtos = new List<Produto>();

        //POST: api/produto/create
        [Route("create")]
        [HttpPost]

        public IActionResult Create([FromBody] Produto produto) 
        
        

      {
            Produto produtoEncontrado = _context.Produtos.FirstOrDefault(p => p.Nome == produto.Nome);
            if (produtoEncontrado == null)

                _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);

        }


        //GET: api/produto/list
        [Route("list")]
        [HttpGet]
        public IActionResult List() => Ok(_context.Produtos.ToList());

        //GET: api/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        //DELETE: /api/produto/delete/name
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {

            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Nome == name);

            if (produto == null)
            {
                return NotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(_context.Produtos.ToList());
        }

        //PUT: api/produto/update
        [HttpPatch]
        [Route("update")]
        public IActionResult Update([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }


    }


}
