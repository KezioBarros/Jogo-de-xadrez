using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao pocisao {  get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            this.pocisao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;           
        }
    }
}
