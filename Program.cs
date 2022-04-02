/*// Exercício 3
// Você está desenvolvendo um sistema para uma loja virtual de eletrônicos
// que vende Celulares(R$500), Computadores(R$2000) e video games(R$1500)
// O Objetivo do seu sistema é realizar compras online com as seguintes regras
// Primeiro devemos Cadastrar nosso Usuário.

// Todo usuário deve ter nome e e-mail
//Esse usuário comprará produtos 
// Todo produto deve ter: o valor, quantidadeDisponivel e Marca, valor e quantidade devem ser definidos na criação do produto
// Video games podem ser vendidos junto a jogos, sabe-se que cada jogo custa 30 reais
// A loja virtual deve contar com um carrinho
// No carrinho você deve guardar o usuário, os produtosEscolhidos e o valorTotal da compra, por padrão nosso carrinho só poderá guardar até 5 itens.

// O Carrinho deve nascer apenas com o usuario e dentro do carrinho deve se ter o comportamento de adicionar mais itens(deve se verificar se há quantidade disponivel) e fecharCompra
//Para a criação do metódo AdicionarItem voce precisará verificar maior posição sem item do array(para nao adicionar numa posi~çao que já tem item)
// Seu programa deve preencher as informações(dados do usuário, carrinho e produtos de acordo com o input do usuário) - vide vídeo de exemplo
public class Program*/
namespace exercicioLojaOnline.LojaOnline
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo a loja virtual");


            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu nome: ");
            string Email = Console.ReadLine();
            Usuario usuario = new Usuario(nome,Email);
            Carrinho()
          
            






        }
    }
}