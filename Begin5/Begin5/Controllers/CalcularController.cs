using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcularController : ControllerBase
    {
        [HttpGet("ParImpar")]
        public string ParImpar(int meuNumero)
        {
            Random numeroMaquina = new Random();
            var maquina = numeroMaquina.Next(1,10);

            if (((meuNumero + maquina) % 2) == 0)
            {
                return "Par você venceu: você colocou " + meuNumero.ToString() + " e a maquina: " + maquina.ToString();
             }
            else
            {
                return "Impar você perdeu você colocou " + meuNumero.ToString() + " e a maquina: " + maquina.ToString();
            }


        }
        [HttpGet("Multiplicar")]        
        public double Multiplicar(double fator1, double fator2)
        {
            return fator1 * fator2;
        }

        [HttpGet("Somar")]
        public double Somar(double fator1, double fator2)
        {
            return fator1 + fator2;
        }

        [HttpGet("Dividir")]
        public double Dividir(double fator1, double fator2)
        {

            if (fator2  == 0)
            {
                return 999;
            }
            return fator1 / fator2;
                       
        }
        [HttpGet("Subtrair")]
        public double Subtrair(double fator1, double fator2)
        {
            return fator1 - fator2;
        }
    }
}
