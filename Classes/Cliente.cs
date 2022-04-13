namespace projetoLivraria.Classes
{
    public class Cliente : Usuario
    {
        public string Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTerminoPrevista { get; set; }
        public List<Emprestimos> Emprestimos { get; set; }

    }
}