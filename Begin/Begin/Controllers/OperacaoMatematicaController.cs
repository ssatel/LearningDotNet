using Begin.Models;
using Begin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Begin.Controllers
{
    public class OperacaoMatematicaController : ApiController
    {
        private OperacaoMatematicaRepository operacaoRepository;

        public OperacaoMatematicaController()
        {
            operacaoRepository = new OperacaoMatematicaRepository();
        }

        public OperacaoMatematica[] Get()
        {
            return operacaoRepository.GetAllOperacoesMatematicas();
        }

        public HttpResponseMessage Post(OperacaoMatematica operacao) 
        {

            OperacaoMatematica novaOperacao = new OperacaoMatematica();

            novaOperacao.Numero1 = operacao.Numero1;
            novaOperacao.Numero2 = operacao.Numero2;
            novaOperacao.Multiplicar();

            operacaoRepository.SaveOperacaoMatematica(novaOperacao);

            var response = Request.CreateResponse<OperacaoMatematica>(System.Net.HttpStatusCode.Created, novaOperacao);

            return response;

        }
    }
}
