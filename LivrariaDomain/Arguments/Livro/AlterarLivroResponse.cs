using System;
using LivrariaDomain.Entities;
using LivrariaDomain.Resources;

namespace LivrariaDomain.Arguments.Livro
{
    public class AlterarLivroResponse
    {
        public string Isbn { get; set; }
        public string PrimeiroNomeAutor { get; set; }
        public string SobrenomeAutor { get; set; }
        public string NomeLivro { get; set; }
        public float Preço { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string ImagemDaCapa { get; set; }
        public string Mensagem { get; set; }

        public static explicit operator AlterarLivroResponse(Entities.Livro entity)
        {
            return new AlterarLivroResponse()
            {
                Isbn = entity.Isbn.NumeroIsbn,
                PrimeiroNomeAutor = entity.NomeAutor.PrimeiroNome,
                SobrenomeAutor = entity.NomeAutor.Sobrenome,
                NomeLivro = entity.NomeLivro,
                Preço = entity.Preço,
                DataPublicacao = entity.DataPublicacao,
                ImagemDaCapa = entity.ImagemDaCapa,
                Mensagem = Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
