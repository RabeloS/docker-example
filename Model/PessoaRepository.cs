
namespace docker.api.Model
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ContextDocker context;
        public PessoaRepository(ContextDocker context)
        {
            this.context = context;
        }

        public async Task<Pessoa> GetByIdAsync(int id)
        {
            var pessoa = await this.context.Set<Pessoa>().FindAsync(id);
            return pessoa;
        }
    }
}