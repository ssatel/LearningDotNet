using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Application
{
    public class contaApplication : IConta
    {
        public void CriarConta(int titular, int numeroConta, double saldoInicial)
        {
            throw new NotImplementedException();
        }

        void IConta.Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        double IConta.GetSaldo()
        {
            throw new NotImplementedException();
        }

        void IConta.Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
