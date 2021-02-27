
using Begin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Begin.Services
{
    public class OperacaoMatematicaRepository
    {
        private const string CacheKey = "MathStore";

        public OperacaoMatematicaRepository()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var operacao = new OperacaoMatematica[]
                    {
                        new OperacaoMatematica()
                        {
                            Numero1 = 1,
                            Numero2 = 1,
                            Resultado = 1
                        },
                        new OperacaoMatematica()
                        {
                            Numero1 = 1,
                            Numero2 = 2,
                            Resultado = 2
                            
                        }
                    };
                    ctx.Cache[CacheKey] = operacao;
                }

            }

        }

        public OperacaoMatematica[] GetAllOperacoesMatematicas()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (OperacaoMatematica[])ctx.Cache[CacheKey];
            }

            return new OperacaoMatematica[]
            {
                new OperacaoMatematica()
                {
                    Numero1 = 1,
                    Numero2 = 1,
                    Resultado = 1
                }
            };
        }

        public bool SaveOperacaoMatematica(OperacaoMatematica operacao)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((OperacaoMatematica[])ctx.Cache[CacheKey]).ToList();
                                  

                    currentData.Add(operacao);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    return false;
                }
            }
            return false;
        }
    }
}