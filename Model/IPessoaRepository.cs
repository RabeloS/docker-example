using docker.api.Controllers;

namespace docker.api.Model
{
    public interface IPessoaRepository
    {
        Task<Pessoa> GetByIdAsync(int id);
    }
}