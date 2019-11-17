using LivrariaDomain.Entities.Base;
using LivrariaDomain.Resources;
using LivrariaDomain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace LivrariaDomain.Entities
{
    public class Livro : BaseEntity
    {
        // ISBN, Autor, Nome, Preço, Data Publicação, Imagem da Capa
            public ISBN Isbn  { get; set; }
            public Nome  Autor { get; set; }
            public string Nome { get; set; }
            public float Preço { get; set; }
            public DateTime DataPublicacao { get; set; }
            public string ImagemDaCapa { get; set; }

        public Livro(ISBN isbn, Nome autor, string nome, float preço, DateTime dataPublicacao, string imagemDaCapa )
        {
            Isbn = isbn;
            Autor = autor;
            Nome = nome;
            Preço = preço;
            DataPublicacao = dataPublicacao;
            ImagemDaCapa = imagemDaCapa;

            ValidarEntidade();

            AddNotifications(autor, isbn);

        }
        private void ValidarEntidade()
        {
            new AddNotifications<Livro>(this)
                .IfNullOrInvalidLength(x => x.Nome, 1, 100, Message.O_PREENCHIMENTO_CAMPO_X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome", "1", "100"));
        }


    }
}
