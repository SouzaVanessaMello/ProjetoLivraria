using LivrariaDomain.Interfaces.Arguments;
using System;

namespace LivrariaDomain.Arguments.Livro
{
    public class AdicionarLivroRequest : IRequest
    {
        public string Isbn { get; set; }
        public string PrimeiroNomeAutor { get; set; }
        public string SobrenomeAutor { get; set; }
        public string NomeLivro { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
    }
}
