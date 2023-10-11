using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Equilibrista : Artista
    {
        internal string TipoDeEquipamento { get; set; }
        internal double AlturaDoEquilibrio { get; set; }
        private int dificuldade;
        internal int Dificuldade
        {
            get
            {
                return dificuldade;
            }
            set
            {
                if (value > 10)
                { 
                    value = 10;
                }
                dificuldade = value;
            }
        }

        public Equilibrista(string nome, int tempoApresentacao, DateTime dataInicio, string tipoDeEquipamento, double alturaDoEquilibrio, int dificuldade)
            : base(nome, tempoApresentacao, dataInicio)
        {
            TipoDeEquipamento = tipoDeEquipamento;
            AlturaDoEquilibrio = alturaDoEquilibrio;
            Dificuldade = dificuldade;
        }

        public void ApresentaEquilibrista()
        {
            ExibirInformacoes();
            Console.WriteLine("Tipo de equipamento: " + TipoDeEquipamento);
            Console.WriteLine("Altura do equilíbrion (metros): " + AlturaDoEquilibrio);
            Console.WriteLine("Dificuldade (0 a 10): " + Dificuldade);
            Console.WriteLine();
        }
    }
}
