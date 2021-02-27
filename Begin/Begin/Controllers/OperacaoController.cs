using Begin.Models;
using Begin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Begin.Controllers
{
    [RoutePrefix("api/Operacao")]
    public class OperacaoController : ApiController
    {
        private OperacaoMatematicaRepository operacaoRepository;

        public OperacaoController()
        {
            operacaoRepository = new OperacaoMatematicaRepository();
        }

        [HttpGet]
        [Route("Multiplicar")]
        public double Multiplicar(double num1, double num2)
        {
            return (num1 * num2);
        }

        [HttpGet]
        [Route("Dividir")]        
        public double Dividir(double num1, double num2)
        {
            return (num1 / num2);
        }
        
        [HttpGet]
        [Route("Somar")]
        public double Somar(double num1, double num2)
        {
            return (num1 + num2);
        }

        [HttpGet]
        [Route("Subtrair")]
        public double Substrair(double num1, double num2)
        {
            return (num1 - num2);
        }

        [HttpPost]
        [Route("Multiplicar")]
        public HttpResponseMessage Multiplicar(OperacaoMatematica operacao)
        {

            OperacaoMatematica novaOperacao = new OperacaoMatematica();


            novaOperacao.Numero1 = operacao.Numero1;
            novaOperacao.Numero2 = operacao.Numero2;
            novaOperacao.Multiplicar();
            
            var response = Request.CreateResponse(System.Net.HttpStatusCode.Created, novaOperacao.Resultado);

            return response;

        }
        [HttpPost]
        [Route("Dividir")]
        public HttpResponseMessage Dividir(OperacaoMatematica operacao)
        {

            OperacaoMatematica novaOperacao = new OperacaoMatematica();

            novaOperacao.Numero1 = operacao.Numero1;
            novaOperacao.Numero2 = operacao.Numero2;
            novaOperacao.Dividir();
            var response = Request.CreateResponse<OperacaoMatematica>(System.Net.HttpStatusCode.Created, novaOperacao);

            return response;

        }

        [HttpPost]
        [Route("Somar")]
        public HttpResponseMessage Somar(OperacaoMatematica operacao)
        {

            OperacaoMatematica novaOperacao = new OperacaoMatematica();

            novaOperacao.Numero1 = operacao.Numero1;
            novaOperacao.Numero2 = operacao.Numero2;
            novaOperacao.Somar();
            var response = Request.CreateResponse<OperacaoMatematica>(System.Net.HttpStatusCode.Created, novaOperacao);

            return response;

        }

        [HttpPost]
        [Route("Subtrair")]
        public HttpResponseMessage Subtrair(OperacaoMatematica operacao)
        {

            OperacaoMatematica novaOperacao = new OperacaoMatematica();

            novaOperacao.Numero1 = operacao.Numero1;
            novaOperacao.Numero2 = operacao.Numero2;
            novaOperacao.Subtrair();
            var response = Request.CreateResponse<OperacaoMatematica>(System.Net.HttpStatusCode.Created, novaOperacao);

            return response;

        }
        [HttpPut]
        [Route("Gravar")]
        public HttpResponseMessage Gravar(OperacaoMatematica operacao)
        {
            
            operacaoRepository.SaveOperacaoMatematica(operacao);

            var response = Request.CreateResponse<OperacaoMatematica>(System.Net.HttpStatusCode.Created, operacao);

            return response;

        }


    }
}
