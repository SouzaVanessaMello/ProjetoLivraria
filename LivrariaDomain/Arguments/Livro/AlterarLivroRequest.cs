using System;

namespace LivrariaDomain.Arguments.Livro
{
    public class AlterarLivroRequest
    {
        public Guid Id { get; set; }
        public string Isbn { get; set; }
        public string PrimeiroNomeAutor { get; set; }
        public string UltimoNomeAutor { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
    }
}
