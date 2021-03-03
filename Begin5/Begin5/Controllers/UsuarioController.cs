using AutoMapper;
using Begin5.Infra;
using Begin5.Models;
using Begin5.Services;
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
            var usuarioExistente = await UsuarioService.BuscarUsuarioEmail(usuario.Email);
            if (usuarioExistente == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ja existe um usuario com este email");
            }

            usuarioExistente = await UsuarioService.BuscarUsuarioUserId(usuario.UserID);

            if (usuarioExistente == null)
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

            var usuarioExistente = await UsuarioService.BuscarUsuarioUserId(usuario.UserID);

            if (usuarioExistente == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Usuario não encontrado");
            }

            var EmailExistente = await UsuarioService.BuscarUsuarioEmail(usuario.Email);

            if (EmailExistente == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Este e-mail ja esta em uso");
            }

            using (var context = new Context()) 
            {
                var usuarioAlteracao = context.Usuario.SingleOrDefault(u => u.UserID == usuarioExistente.UserID);

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

            var usuario = await UsuarioService.BuscarUsuarioUserId(userId);

            if (usuario == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Usuario não encontrado");
            }

            usuarioExistente.Add(new UsuarioResponseDTO(usuario.UserID, usuario.Email, usuario.IDusuario));
            
            return Ok(usuarioExistente.ToArray());
        }
                

    }
}
