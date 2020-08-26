using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercícios
{
    class Aluno
    {
        public int Cpf = 0;
        public string Nome = "";
        public double Grade1 = 0;
        public double Grade2 = 0;
        public double Grade3 = 0;

        public Aluno(int cpf, string nome)
        {
            this.Cpf = cpf; 
            this.Nome = nome;

        }
        public void initializeGrade(double grade, int whatGrade)
        {
            if (whatGrade == 1)
            {
                this.Grade1 = grade;
            }
            else if (whatGrade == 2)
            {
                this.Grade2 = grade;
            }
            else if (whatGrade == 3)
            {
                this.Grade3 = grade;
            }
            else 
            {
                Console.WriteLine("Put the right grade, motherfucker!");
            }
        }

        public bool verifyAverage()
        {
            double average = (this.Grade1 + this.Grade2 + this.Grade3) / 3;
            if(average >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string printInformation()
        {
            return "Student: " + this.Nome + "\n" + "CPF: " + this.Cpf + "\n" + "Grade 1: " + this.Grade1 + "Grade 2: " + this.Grade2 + "Grade 3: " + this.Grade3;
        }

    }
}
