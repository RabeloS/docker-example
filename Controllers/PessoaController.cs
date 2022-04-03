using docker.api.Model;
using Microsoft.AspNetCore.Mvc;

namespace docker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository repository;
        public PessoaController(IPessoaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<Pessoa> Get(int id)
        {
            var pessoa = await this.repository.GetByIdAsync(id);
            return pessoa;
        }

    }
}