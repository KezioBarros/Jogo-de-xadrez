﻿namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas {  get; set; }
        private Peca[,] peca;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            peca = new Peca[linhas, colunas];
        }
    }
}
