using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console.tabuleiro;
using xadrez;
using xadrez_console;


namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadres partida = new PartidaDeXadres();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Digite a posicao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }             
                
            }
            catch (TabuleiroException ex) 
            {
                Console.WriteLine(ex.Message);   
            }
            Console.ReadLine();
        }
    }
}
