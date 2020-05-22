using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {

        /* Atributos */

        private string nome;
        private double peso, altura;
        private int idade;

        /* Getters & Setters */

        public string Nome
        {
            set
            {
                if(value!= string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser preenchido");
                }
            }
            get
            {
                return this.nome;
            }
        }

        public double Altura
        {
            set
            {
                if(value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Altura inválida");
                }
            }
            get
            {
                return this.altura;
            }
        }

        public double Peso
        {
            set
            {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("Peso inválido");
                }
            }
            get
            {
                return this.peso;
            }
        }

        public int Idade
        {
            set
            {
                if(value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("Idade inválida");
                }
            }
            get
            {
                return this.idade;
            }
        }
        /* Métodos */
        public string ImprimirDados()
        {
            return "Dados do atleta:\nNome: " + this.nome +
                "\nAltura: " + this.altura +
                "\nPeso: " + this.peso +
                "\nIdade: " + this.idade;
        }

        public double CalcularIMC()
        {
            return (this.peso / Math.Pow(this.altura, 2));
        }
    }
}
