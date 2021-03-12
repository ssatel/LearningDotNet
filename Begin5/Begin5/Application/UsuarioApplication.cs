using Begin5.Application.Interface;
using Begin5.Entidades;
using Begin5.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        //public static async Task<Usuario> BuscarUsuarioUserId(string userId)
        //{
        //    Usuario usuarioExistente = new Usuario();

        //    using (var context = new Context())
        //    {
        //        usuarioExistente = context.Usuario.Where(u => u.UserID == userId).FirstOrDefault();

        //    }
        //    return usuarioExistente;
        //}

        //public static async Task<Usuario> BuscarUsuarioEmail(string email)
        //{
        //    Usuario usuarioExistente = new Usuario();
        //    using (var context = new Context())
        //    {
        //        usuarioExistente = context.Usuario.Where(u => u.Email == email).FirstOrDefault();
        //    }
        //    return usuarioExistente;
        //}
        public async  Task<Usuario> BuscarUsuarioEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> BuscarUsuarioUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
