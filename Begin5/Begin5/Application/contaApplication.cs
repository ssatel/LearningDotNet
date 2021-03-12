using Begin5.Application.Interface;
using Begin5.Entidades;
using Begin5.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Application
{
    public class ContaApplication : IContaApplication
    {
        private readonly IContaRepository _contaRepository;
        public ContaApplication(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public async Task Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        public async Task<double> GetSaldo()
        {
            throw new NotImplementedException();
        }

        public async Task Sacar(double valor)
        {
            throw new NotImplementedException();
        }

        public async Task CriarConta(string titular, int numeroConta, double saldoInicial)
        {
            await _contaRepository.CriarConta(new Conta() { UserID = titular, NumeroConta = numeroConta, Saldo = saldoInicial });
                      
        }
    }
}
