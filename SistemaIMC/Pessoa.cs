using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIMC
{
    internal class Pessoa //internal: SÓ POSSO USAR NESSE NAMESPACE.
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }

        public Pessoa(string nome, int idade, double peso, double altura) 
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        } 

        public string LerNome()
        {
           return Nome;
        }
        public int LerIdade()
        {
            return Idade;
        }
        public double LerPeso()
        {
            return Peso;
        }
        public double LerAltura()
        {
            return Altura;
        }

        public void MudarNome(string nome)
        {
            Nome = nome;
        }
        public void MudarIdade(int idade)
        {
            Idade = idade;
        }
        public void MudarPeso(double peso)
        {
            Peso = peso;
        }
        public void MudarAltura(double altura)
        {
            Altura = altura;
        }

        public static void CalcularIMC(double peso, double altura)
        {
            double imc = 0;
            imc = peso/(altura * altura);
        }

        public static string FaixaDeCategoria(double imc)
        {
            string resultado = "";

            if (imc < 18.5)
            {
                resultado = "Abaixo do Peso!";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                resultado = "Peso Normal!";
            }
            else if (imc >= 25 && imc < 30)
            {
               resultado =  "SobrePeso!";
            }
            else if (imc >= 30 && imc < 35)
            {
               resultado = "Obesidade Grau 1!";
            }
            else if (imc >= 35 && imc < 40)
            {
                resultado = "Obesidade Grau 2!";
            }
            else 
            {
                resultado = "Obesidade Grau 3!";
            }
            return resultado;
        }

        ~Pessoa() { }
    }
}
