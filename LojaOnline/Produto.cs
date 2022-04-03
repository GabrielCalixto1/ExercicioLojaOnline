namespace exercicioLojaOnline.LojaOnline
{
    public class Produto
    {
        public double ValorProduto { get; set; }
        public double QuantidadeDisponivel { get; set; }

        public string Marca { get; set; }
        public Produto(double valorProduto, double quantidadeDisponivel, string marca)
        {
            ValorProduto = valorProduto;
            QuantidadeDisponivel = quantidadeDisponivel;
            Marca = marca;
        }

       /* public void ComprouUmItem();
        {
            QuantidadeDisponivel--;
        }*/

    }
}

