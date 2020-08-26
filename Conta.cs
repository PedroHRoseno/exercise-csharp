using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercícios
{
    class Conta
    {
        private int N_conta;
        private string Nome;
        private float Saldo;

        public Conta(int n_conta, string nome, float saldo)
        {
            Nome = nome;
            N_conta = n_conta;
            Saldo = saldo;

        }

        public Conta(int n_conta, string nome)
        {
            Nome = nome;
            N_conta = n_conta;

        }

        public int GetNconta()
        {
            return this.N_conta;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public float GetNSaldo()
        {
            return this.Saldo;
        }

        public void Deposito(float valor)
        {
            this.Saldo += valor;
        }

        public void Saque(float valor)
        {
            if ((this.Saldo - valor) > -1)
            {
                this.Saldo -= valor + 5;
            }
            else
            {
                Console.WriteLine("Operação não suportada!");
            }
        }
        public override string ToString()
        {
            return "N. Conta : " + this.N_conta.ToString()+ "| Nome: " +this.Nome + "| Saldo : R$"+ this.Saldo.ToString();
        }

    }

    }   


