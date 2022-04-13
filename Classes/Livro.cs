namespace projetoLivraria.Classes
{
    public class Livro
    {
        public string Titulo { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public string Edicao { get; set; }
        public Editora Editora { get; set; }
        public string Autor { get; set; }
        public string Classificacao { get; set; }
        public string Idioma { get; set; }
        public bool Disponibilidade { get; set; }
    }
}