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
           Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colacarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.colacarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colacarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
