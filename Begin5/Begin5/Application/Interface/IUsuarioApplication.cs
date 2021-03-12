using Begin5.Entidades;
using System.Threading.Tasks;

namespace Begin5.Application.Interface
{
    public interface IUsuarioApplication
    {
        Task<Usuario> BuscarUsuarioUserId(string userId);

        Task<Usuario> BuscarUsuarioEmail(string email);
    }
}
