﻿using Begin5.Application;
using Begin5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Models
{
    
    public class ContaRepository : IConta
    {
       
        public int IdConta { get; set; }
        public string UserID { get; set; }
        public int NumeroConta { get; set; }
        private double Saldo { get; set; }

        public ContaRepository() { }
                
        public void CriarConta(int titular, int numeroConta, double saldoInicial)
        {
            if (numeroConta == 0)
            {
                throw new ContaException("Numero da conta não foi informado");
            }

            if (saldoInicial < 0 )
            {
                throw new ContaException("O Saldo inicial não pode ser negativo");
            }

            
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            if (Saldo <= valor)
            {
                throw new ContaException("Saldo Insuficiente");
            }
            Saldo -= valor;

        }

        public void Depositar(double valor)
        {
            if (valor <= 0 )
            {
                throw new ContaException("Valor de deposito deve ser maior que zero");
            }
            Saldo += valor;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

    }
}