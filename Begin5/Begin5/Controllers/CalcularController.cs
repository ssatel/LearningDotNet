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
            return fator1 / fator2;
        }
        [HttpGet("Subtrair")]
        public double Subtrair(double fator1, double fator2)
        {
            return fator1 - fator2;
        }
    }
}
