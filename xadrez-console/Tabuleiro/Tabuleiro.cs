using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas {  get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linaha,  int colunas)
        {
            return pecas[linaha, colunas];
        }

        public void colacarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.pocisao = pos;
        }
    }
}
