namespace exercicioLojaOnline.LojaOnline
{
    public class VideoGame : Produto
    {
      public double QuantidadeDeJogos {get; set;}

        public VideoGame() : base(1500, 5, "Ps4")
        {

        }
        public void AdicionarJogos(double quantidadeDeJogos)    
        {
            QuantidadeDeJogos = quantidadeDeJogos;
            ValorProduto = ValorProduto + (30*quantidadeDeJogos);

        }
    }

}
