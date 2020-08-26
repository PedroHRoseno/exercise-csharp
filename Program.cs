using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 568.0;
            double medida = 53.28323;

            Console.WriteLine($"Produtos: /n computador, cujo preço é $ {preco1} /n mesa de escritório, cujo preço é {preco2} /n Registro: {idade} anos de idade, código {codigo} e genero: {genero}");
            */

            // Exercício 1 //
            /*
            int n1, n2;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("o resultado da soma dos dois números é: " + (n1 + n2));
            */

            // Exercicio 2 //
            /*
            Console.Write("Digite a área do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaCirculo = 3.14159 * (raio * raio);
            Console.WriteLine(areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
            */

            //Exercício 3//                                                                                                                                                                                                             
            /*
            int n1, n2, n3, n4;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            n4 = int.Parse(Console.ReadLine());

            int diferenca = n1 * n2 - n3 * n4;
            Console.WriteLine("DIFERENÇA = " + diferenca);
            */

            //Exercício 4//
            /*
            float n1, n2, n3;
            Console.WriteLine("Digite um número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");

            float areaTrapezio = ((n1 + n2) * n3) / 2;
            Console.WriteLine("A area do trapézio é: " + areaTrapezio);
            */

            //Exercício 5//
            /*
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("Esse número é positivo!");
            }
            else
            {
                Console.WriteLine("Esse número é negativo!");
            }
            */

            // ´Exercícios 6 - Classe //

            /*
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Digite o nome e idade da 1 pessoa: ");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e idade da 2 pessoa: ");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + x.Nome);
            }
            else if (y.Idade > x.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + y.Nome);
            }
            else
            {
                Console.WriteLine("Mesma idade");
            }
            */

            //Exercício 7//

            /*
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Digite o nome e salario da 1 pessoa: ");
            x.Nome = Console.ReadLine();
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e salario da 2 pessoa: ");
            x.Nome = Console.ReadLine();
            y.Salario = double.Parse(Console.ReadLine());

            double media = (x.Salario + y.Salario) / 2;
            Console.WriteLine("A media salarial é: " + media);
            */

            /*
            Console.WriteLine("Entre com o numero da conta:");
            int numero_conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu nome:");
            string nome_conta = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial y/n?");
            string yesorno = Console.ReadLine();

            if (yesorno == "n")
            {
                Conta minha_conta = new Conta(numero_conta, nome_conta);
                Console.WriteLine(minha_conta);
            }
            else
            {
                Console.WriteLine("Qual o valor do deposito inicial?");
                float deposito_inicial = float.Parse(Console.ReadLine());
                Conta minha_conta = new Conta(numero_conta, nome_conta, deposito_inicial);
                Console.WriteLine(minha_conta);
                minha_conta.Saque(1000);
                Console.WriteLine(minha_conta);
                minha_conta.Deposito(5000);
                Console.WriteLine(minha_conta);
            }
            */

            //Exercicio 8//
            /*
            Console.WriteLine("Quantos quartos serão alugados?");
            int quantidade = int.Parse(Console.ReadLine());
            Aluguel[] quartos = new Aluguel[10];
            for(int x=0; x < quantidade; x++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                Aluguel alugou_quarto = new Aluguel(x, nome, email, quarto);
                quartos[quarto] = alugou_quarto;

            }

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(quartos[x]);
            }
            */

            //Exercicio 9//

            /*
            string[] line = Console.ReadLine().Split(' ');
            int l = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            int[,] neoMatrix = new int[l, c];

            List<int> randoms = new List<int>();

            for (int x = 0; x < l; x++)
            {
                for (int y = 0; y < c; y++)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 51);
                    randoms.Add(randomNumber);
                    neoMatrix[x, y] = randomNumber;
                }
            }

            randoms.ForEach(Console.WriteLine);
            Console.WriteLine("Type a number, that owns in the list above.");
            int searchNumber = int.Parse(Console.ReadLine());

            for (int x = 0; x < l; x++)
            {
                for (int y = 0; y < c; y++)
                {
                   if (neoMatrix[x, y] == searchNumber)
                    {
                        Console.WriteLine("found! Position: ["+x+","+y+"]");
                        if (y > 0)
                        {
                            Console.WriteLine("Left: " + neoMatrix[x, y - 1]);
                        }
                        if (x > 0)
                        {
                            Console.WriteLine("Up: " + neoMatrix[x - 1, y]);
                        }
                        if (y < c - 1 )
                        {
                            Console.WriteLine("Right" + neoMatrix[x, y + 1]);
                        }
                        if (y < l - 1)
                        {
                            Console.WriteLine("Right" + neoMatrix[x + 1, y]);
                        }
                    }
                }
            }
            */
            //Exercicio 10//
            LinkedList lista = new LinkedList();
            lista.Append(20);
            lista.Append(30);
            lista.Append(40);
            lista.Append(50);
            Console.WriteLine(lista.Head.Next.Next.Next.Value);
            Console.WriteLine(lista.printList());
            lista.RemoveByTheEnd();
            Console.WriteLine(lista.Head.Next.Next.Next.Value);
            Console.WriteLine(lista.printList());

            //Exercicio 11//   
            /*
            Aluno aluno1 = new Aluno(109995, "pedro");
            aluno1.initializeGrade(10, 1);
            aluno1.initializeGrade(5, 2);
            aluno1.initializeGrade(2, 3);
            bool passou = aluno1.verifyAverage();
            Console.WriteLine(passou);
            string imprimir = aluno1.printInformation();
            Console.WriteLine(imprimir);
            */

            {

            }


        }
    }
}
