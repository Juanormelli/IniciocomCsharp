using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioCursoCSharp
{
    class CadastroQuarto
    {
        public string Nome { get; set; }
        public int NumeroQuarto { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Nome, " + Nome + ", Email, " + Email + ", Quarto Alugado, " + NumeroQuarto;
        }
    }
}
