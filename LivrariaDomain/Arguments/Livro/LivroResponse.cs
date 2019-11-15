using LivrariaDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDomain.Arguments.Livro
{
    public class LivroResponse
    {
        public string Isbn { get; set; }
        public string NomeAutor { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
        
        public static explicit operator LivroResponse (Entities.Livro entity)
        {
            return new LivroResponse()
            {
                Nome = entity.Nome,
                Isbn = entity.Isbn.NumeroIsbn,
                NomeAutor = entity.Autor.PrimeiroNome + " " + entity.Autor.Sobrenome,
                DataPublicacao = entity.DataPublicacao,
                //ImagemDaCapa = entity.ImagemDaCapa,
                Preço = entity.Preço

            };
        }

    }
}
