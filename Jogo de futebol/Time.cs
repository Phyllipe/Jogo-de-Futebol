using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_de_futebol
{
    class Time
    {
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> jogadores;

        public Time(string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.jogadores = new List<Jogador>();

        }

        public string Nome
        {
            get { return nome; }
        }
        public string getStatus()
        {
            return "O status do Time " + this.Nome + " é Vitorias: " + this.Vitorias + "\tDerrotas: " + this.Derrotas + "\tEmpates: " + this.Empates;
        }
        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }

        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }
        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }
        public void contratarJogador(Jogador a)
        {
            this.jogadores.Add(a);
        }
        private string demitirJogador(Jogador a)
        {
            int buscarJogador = this.jogadores.IndexOf(a);
            string strRetorno = "Jogador" + a.getNome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return strRetorno + " demitido.";
            }
            return "Não foi possível demitir " + strRetorno;
        }
        private Jogador getJogador(int camisa)
        {
            return jogadores.Find(a => a.getCamisa().Equals(camisa));

        }
        public void gol(int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }
        public void getDescricaoJogadores()
        {
            foreach (Jogador jog in jogadores)
            {

                Console.WriteLine(jog.getDescricao());
            }



        }
    }
}
