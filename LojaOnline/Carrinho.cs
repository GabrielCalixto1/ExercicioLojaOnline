namespace exercicioLojaOnline.LojaOnline
{
    public class Carrinho
    {
        public Usuario Usuario { get; set; }

        public Produto[] ProdutosSelecionados { get; set; }

        public Carrinho(Usuario usuario)
        {
            Usuario = usuario;
            var ProdutosSelecionados = new List<Produto>(5);

        }
        public void AdicionarNovoProduto(Produto produtos)
        {
           


        }


    }

}