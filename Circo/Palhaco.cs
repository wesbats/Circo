using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Palhaco : Artista
    {
        internal bool NarizVermelho { get; set; }
        internal bool Maquiagem {  get; set; }
        internal int NumeroPiadas { get; set; }
        
        internal Palhaco(string nome, int tempoApresentacao, DateTime dataInicio, bool NarizVermelho, bool Maquiagem, int NumeroPiadas)
            :base(nome, tempoApresentacao, dataInicio)
        {
            this.NarizVermelho = NarizVermelho;
            this.Maquiagem = Maquiagem;
            this.NumeroPiadas = NumeroPiadas;
        }

        internal void ApresentaPalhaco()
        {
            base.ExibirInformacoes();
            Console.WriteLine("Utiliza nariz vermelho?: " + (NarizVermelho ? "Sim" : "Não"));
            Console.WriteLine("Utiliza maquiagem: " + (Maquiagem ? "Sim" : "Não")); ;
            Console.WriteLine("Numeros de piadas: " + NumeroPiadas);
            Console.WriteLine();
        }
    }
}
