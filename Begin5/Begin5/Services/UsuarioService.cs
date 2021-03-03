using Begin5.Infra;
using Begin5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Services
{
    public static class UsuarioService
    {
        public static async Task<Usuario> BuscarUsuarioUserId(string userId)
        {
            Usuario usuarioExistente = new Usuario();

            using (var context = new Context())
            {
                usuarioExistente = context.Usuario.Where(u => u.UserID == userId).FirstOrDefault();

            }
            return usuarioExistente;
        }

        public static async Task<Usuario> BuscarUsuarioEmail (string email)
        {
            Usuario usuarioExistente = new Usuario();
            using (var context = new Context())
            {
                usuarioExistente = context.Usuario.Where(u => u.Email == email).FirstOrDefault();
            }
            return usuarioExistente;
        }
    }
}
