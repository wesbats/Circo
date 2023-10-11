using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Malabarista : Artista
    {
        internal int NumeroDeObjetos { get; set; }
        internal string TipoDeObjetos { get; set; }
        internal double AlturaDosLancamentos { get; set; }

        public Malabarista(string nome, int tempoApresentacao, DateTime dataInicio, int numeroDeObjetos, string tipoDeObjetos, double alturaDosLancamentos)
            : base(nome, tempoApresentacao, dataInicio)
        {
            NumeroDeObjetos = numeroDeObjetos;
            TipoDeObjetos = tipoDeObjetos;
            AlturaDosLancamentos = alturaDosLancamentos;
        }

        public void ApresentaMalabarista()
        {
            ExibirInformacoes();
            Console.WriteLine("Número de objetos: " + NumeroDeObjetos);
            Console.WriteLine("Tipo de objetos: " + TipoDeObjetos);
            Console.WriteLine("Altura dos lançamentos: " + AlturaDosLancamentos);
            Console.WriteLine();
        }
    }
}
