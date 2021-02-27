using Begin5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Begin5.Exceptions;
using AutoMapper;

namespace Begin5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ContaCorrenteController : ControllerBase
    {
        public static Conta contaAtiva = null;

        IMapper _mapper;

        public ContaCorrenteController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> CriarConta(ContaRequestDTO contaDTO)
        {
            try
            {
                var contaAux = _mapper.Map<Conta>(contaDTO);

                contaAtiva = contaAux;
            }
            catch (ContaException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
                       
            return Ok();
        }
        [HttpPost("Sacar")]
        public async Task<IActionResult> Sacar([FromBody] double valor)
        {
            
            try
            {
                if (contaAtiva != null)
                {
                    contaAtiva.Sacar(valor);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                        
            }
            catch (ContaException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return Ok();
        }

        [HttpPost("Depositar")]
        public async Task<IActionResult> Depositar([FromBody] double valor)
        {
            
            try
            {
                if (contaAtiva != null)
                {
                    contaAtiva.Depositar(valor);
                }
                else 
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (ContaException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
            return Ok();
        }

        [HttpGet("Saldo")]
        public async Task<IActionResult> Saldo()
        {
            try
            {
                if (contaAtiva != null)
                {
                    return Ok(contaAtiva.GetSaldo());
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                
            }
            
        }
    }
}
