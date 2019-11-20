using System;
using LivrariaDomain.Entities;

namespace LivrariaDomain.Arguments.Livro
{
    public class LivroResponse
    {
        public string Isbn { get; set; }
        public string NomeAutor { get; set; }
        public string NomeLivro { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }


        public static explicit operator LivroResponse(Entities.Livro entity)
        {
            return new LivroResponse()
            {
                Isbn = entity.Isbn.NumeroIsbn,
                NomeAutor = entity.NomeAutor.PrimeiroNome + " " + entity.NomeAutor.Sobrenome,
                NomeLivro = entity.NomeLivro,
                Preço = entity.Preço,
                DataPublicacao = entity.DataPublicacao,
                ImagemDaCapa = entity.ImagemDaCapa,

            };
        }

    }
}
