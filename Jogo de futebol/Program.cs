using System;

namespace Jogo_de_futebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Flamengo");
            time1.contratarJogador(new Jogador("Diego", 34, 89, 1));
            time1.contratarJogador(new Jogador("Rodrigo", 26, 82, 2));
            time1.contratarJogador(new Jogador("Léo", 24, 83, 3));
            time1.contratarJogador(new Jogador("Gustavo", 27, 80, 4));
            time1.contratarJogador(new Jogador("Filipe", 34, 87, 5));
            time1.contratarJogador(new Jogador("Rene", 27, 86, 6));
            time1.contratarJogador(new Jogador("Willian", 27, 90, 7));
            time1.contratarJogador(new Jogador("Everton", 31, 92, 8));
            time1.contratarJogador(new Jogador("Gabriel", 23, 98, 9));
            time1.contratarJogador(new Jogador("Bruno", 29, 95, 11));
            time1.contratarJogador(new Jogador("Diego", 35, 97, 10));


            Time time2 = new Time("Palmeiras");
            time2.contratarJogador(new Jogador("Weverton", 32, 80, 1));
            time2.contratarJogador(new Jogador("Jailson", 38, 78, 2));
            time2.contratarJogador(new Jogador("Vitor", 28, 82, 3));
            time2.contratarJogador(new Jogador("Luan", 26, 82, 4));
            time2.contratarJogador(new Jogador("Diogo", 27, 84, 5));
            time2.contratarJogador(new Jogador("Felipe", 36, 86, 6));
            time2.contratarJogador(new Jogador("Ramires", 33, 84, 7));
            time2.contratarJogador(new Jogador("Lucas", 29, 84, 8));
            time2.contratarJogador(new Jogador("Dudu", 28, 88, 9));
            time2.contratarJogador(new Jogador("Luiz", 33, 95, 10));
            time2.contratarJogador(new Jogador("Willian", 33, 92, 11));




            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();

            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores();

            Console.ReadKey();
        }
    }
}
