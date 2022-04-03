namespace exercicioLojaOnline.LojaOnline
{
    public class Carrinho
    {
        public Usuario Usuario { get; set; }

        public List<Produto> ProdutosSelecionados { get; set; }

        public Carrinho(Usuario usuario)
        {
            Usuario = usuario;
            ProdutosSelecionados = new List<Produto>();
        }
        public void AdicionarNovoProduto(Produto produtos)
        {
            ProdutosSelecionados.Add(produtos);
        }
        public double fecharCompra()
        {
            double total = 0;
            foreach (var item in ProdutosSelecionados)
            {

                total = total + item.ValorProduto;

            }
            return total;
        }
    

    }
}


