namespace API
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
    
     //POST: api/produto/criar
        [HttpPost]
        [Route("criar")]
        public IActionResult criar([FromBody] Produto produto)


   
}