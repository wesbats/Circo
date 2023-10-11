using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circo
{
    internal class Artista
    {
        protected string nome {  get; set; }
        protected int tempoApresentacao { get; set; }
        protected DateTime dataInicio { get; set; }
        protected DateTime dataSaida { get; set; }
        protected bool ativo { get; set; } = true;

        internal Artista(string nome, int tempoApresentacao, DateTime dataInicio)
        {
            this.nome = nome;
            this.tempoApresentacao = tempoApresentacao;
            this.dataInicio = dataInicio;
        }

        internal void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de inicio: " + dataInicio);
            Console.WriteLine("Está ativo: " + (ativo ? "Sim" : "Não"));
            if(!ativo)
            {
                Console.WriteLine("Data de saída: " + dataSaida);
            }
            Console.WriteLine("Tempo de apresentação (minutos): " + tempoApresentacao);
        }
        internal void RegistrarSaida()
        {
            dataSaida = DateTime.Now;
            ativo = false;
        }
    }
}
