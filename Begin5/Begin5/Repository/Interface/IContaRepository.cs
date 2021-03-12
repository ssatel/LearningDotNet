using Begin5.Entidades;
using System.Threading.Tasks;

namespace Begin5.Repository.Interface
{
    public interface IContaRepository
    {
        Task CriarConta(Conta conta);
    }
}
