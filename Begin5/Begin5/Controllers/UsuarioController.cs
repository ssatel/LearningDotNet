using AutoMapper;
using Begin5.Infra;
using Begin5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IMapper _mapper;

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("CriarUsuario")]
        public async Task<IActionResult> CriarUsuario(UsuarioRequestDTO usuario)
        {
            var usuarioExistente = await BuscarUsuarioEmail(usuario.Email);
            if (usuarioExistente.Count != 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ja existe um usuario com este email");
            }

            usuarioExistente = await BuscarUsuarioUserID(usuario.UserID);

            if (usuarioExistente.Count != 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ja existe um usuario com este UserID");
            }

            using (var context = new Context())
            {
                var usuarioRetorno = _mapper.Map<UsuarioResponseDTO>(usuario);

                context.Database.EnsureCreated();
                try
                {
                    var novoUsuario = new Usuario(usuario.UserID, usuario.Email);
                    context.Usuario.Add(novoUsuario);
                    context.SaveChanges();
                    usuarioRetorno.IDusuario = novoUsuario.IDusuario;
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
                return Ok(usuarioRetorno);
            }
        }
        [HttpGet("List")]
        public async Task<IActionResult> ListarUsuario()
        {
            var usuariosLogados = new List<UsuarioResponseDTO>();

            using (var context = new Context())
            {
                var listaUsuario = context.Usuario.ToList();
                foreach (Usuario u in listaUsuario)
                {
                    usuariosLogados.Add(new UsuarioResponseDTO(u.UserID, u.Email, u.IDusuario));
                }
            }
            return Ok(usuariosLogados.ToArray());
        }

        [HttpPut("AlterarEmailUsuario")]
        public async Task<IActionResult> AlterarEmailUsuario(UsuarioRequestDTO usuario)
        {

            var usuarioExistente = await BuscarUsuarioUserID(usuario.UserID);

            if (usuarioExistente.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Usuario não encontrado");
            }

            var EmailExistente = await BuscarUsuarioEmail(usuario.Email);

            if (EmailExistente.Count != 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Este e-mail ja esta em uso");
            }

            using (var context = new Context()) 
            {
                var usuarioAlteracao = context.Usuario.SingleOrDefault(u => u.UserID == usuarioExistente.FirstOrDefault().UserID);

                usuarioAlteracao.AtualizarEmail(usuario.Email);

                context.Usuario.Attach(usuarioAlteracao);

                context.Entry(usuarioAlteracao).State = EntityState.Modified;

                context.SaveChanges();

            }

            return Ok();
        }

        [HttpGet("BuscarUsuario")]
        public async Task<IActionResult> BuscarUsuario(string userId)
        {
            var usuarioExistente = new List<UsuarioResponseDTO>();

            var usuario = await BuscarUsuarioUserID(userId);

            if (usuario.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Usuario não encontrado");
            }

            foreach (Usuario u in usuario)
            {
                usuarioExistente.Add(new UsuarioResponseDTO(u.UserID, u.Email, u.IDusuario));
            }
            return Ok(usuarioExistente.ToArray());
        }

        private async Task<List<Usuario>> BuscarUsuarioUserID(string userId)
        {
            using (var context = new Context())
            {
                var usuarioExistente = context.Usuario.Where(u => u.UserID == userId).ToList();

                return (usuarioExistente);
            }
        }

        private async Task<List<Usuario>> BuscarUsuarioEmail(string email)
        {
            using (var context = new Context()) 
            {
                var usuarioExistente = context.Usuario.Where(u => u.Email == email).ToList();
                return (usuarioExistente);
            }

        }

    }
}
