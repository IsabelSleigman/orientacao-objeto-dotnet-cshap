using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }

        public virtual void Aprensentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}