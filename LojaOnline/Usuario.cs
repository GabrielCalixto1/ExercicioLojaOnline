namespace exercicioLojaOnline.LojaOnline
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Produto[] Produtos { get; set; }
        public Usuario (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}