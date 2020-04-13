using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_de_futebol
{
    class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;



        public Jogador(string pNome, int pIdade, int pHab, int Pcamisa)
        {
            this.nome = pNome;
            this.idade = pIdade;
            this.habilidade = pHab;
            this.camisa = Pcamisa;
        }
        public string getNome()
        {

            return nome;
        }
        public int getCamisa()
        {

            return camisa;
        }
        public int getHabilidade()
        {

            return habilidade;
        }
        public int Gols
        {
            get { return gols; }
            set { gols += value; }

        }
        public string getDescricao()
        {

            return "Nome: " + this.getNome() +
                   "\tIdade: " + this.idade +
                   "\tHabilidade: " + this.getHabilidade() +
                   "\tCamisa: " + this.getCamisa() +
                   "\tGols: " + this.Gols;
        }
    }
}
