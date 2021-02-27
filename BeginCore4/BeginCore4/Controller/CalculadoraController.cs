using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginCore4.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        public string [] Calculadora()
        {
            return new string[]
            {
                "Hello",
                "Word"
            };
        }
    }
}
