using tabuleiro;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao pocicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            pocicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;           
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
