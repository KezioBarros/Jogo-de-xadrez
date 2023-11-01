using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}