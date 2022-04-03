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
        public void ClienteCompras()
        {
            Computador dell = new Computador();
            VideoGame ps4 = new VideoGame();
            Celular samsung = new Celular();

            bool opcao3 = true;
            do
            {
                Console.WriteLine($"1- Computador {dell.Marca} \n2- Video Game {ps4.Marca} \n3- Celular {samsung.Marca} ");

                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        AdicionarNovoProduto(dell);
                        break;
                    case "2":
                        Console.WriteLine("Deseja adicionar jogos? S ou N");
                        var jogosOpcao = Console.ReadLine();
                        if (jogosOpcao == "S")
                        {
                            Console.WriteLine("Quantos?");
                            double quantJogos = double.Parse(Console.ReadLine());

                            ps4.AdicionarJogos(quantJogos);
                            AdicionarNovoProduto(ps4);
                        }
                        else if (jogosOpcao == "N")
                        {
                            AdicionarNovoProduto(ps4);
                        }

                        else
                        {
                            Console.WriteLine("Opção Inválida");
                        }

                        break;
                    case "3":
                        AdicionarNovoProduto(samsung);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine("Deseja adicionar algo a mais? S ou N");
                var opcao2 = Console.ReadLine();
                if (opcao2 == "N")
                {
                    opcao3 = false;
                }

                else if (opcao2 == "S")
                {
                    opcao3 = true;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
                ps4.ResetarValor();
            } while (opcao3 == true);

           

        }

    }
}


