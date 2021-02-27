using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Begin.Models
{
    public class OperacaoMatematica
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }

        public OperacaoMatematica()
        {

        }
        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
        }
        public void Dividir()
        {
            Resultado = Numero1 / Numero2;
        }
        public void Somar() 
        {
            Resultado = Numero1 + Numero2;
        }

        public void Subtrair()
        {
            Resultado = Numero1 - Numero2;
        }
    }

}