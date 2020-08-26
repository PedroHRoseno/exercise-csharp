using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exercícios
{
    class Aluguel
    {

            
        public int N_aluguel;
        public string Nome;
        public string Email;
        public int N_quarto;

        public Aluguel(int n_aluguel, string nome, string email, int n_quarto)
        {
            N_aluguel = n_aluguel;
            Nome = nome;
            Email = email;
            N_quarto = n_quarto;
        }

        public override string ToString()
        {
            return "N_aluguel: " + N_aluguel + "\n" + "Nome: " + Nome + "\n" + "Email" + Email + "\n" + "N_quarto: "+ N_quarto;
         }

    }
}
