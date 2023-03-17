using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula160323
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;
        private string telefone;

        public string SobreNome {get; set;}

        public Pessoa(string nome, int idade, double altura, string telefone)
        {
            //this é usado pra diferenciar a palavra nome que esta sendo usada como variavel e 
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.telefone = telefone;
        }
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setAltura(double altura)
        {
            if(altura >0)
            this.altura = altura;
            
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }


        public void imprimirNome()
        {
                 
            Console.WriteLine($" [ {nome}] ");
        }

        public void imprimirInfos()
        {

            Console.WriteLine($" [ {idade} ] " +  $" [{ altura}]"  +  $"[{ altura}]");


        }



    }

    
}
