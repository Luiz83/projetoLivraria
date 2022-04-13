namespace projetoLivraria.Classes
{
    public class Emprestimos
    {
        public Livro LivroEmprestado { get; set; }
        public Usuario Usuario {get;set;}
        public DateTime DataEmprestimo { get; set; }
    }
}