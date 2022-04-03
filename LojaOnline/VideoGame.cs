namespace exercicioLojaOnline.LojaOnline
{
    public class VideoGame : Produto
    {
        public double QuantidadeDeJogos { get; set; }

        public VideoGame() : base(1500, 5, "Ps4")
        {
           
        }
        public void AdicionarJogos(double quantidadeDeJogos)
        {
             base.ValorProduto = base.ValorProduto + (30*quantidadeDeJogos);

        }
        public void ResetarValor()
        {
            var game = new VideoGame();
            game.ValorProduto = 1500;
        }
    }

}
