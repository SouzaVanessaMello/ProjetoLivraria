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
        public Livro(ISBN isbn, Nome nomeAutor, string nome, float preço, DateTime dataPublicacao, string imagemDaCapa)
        {
            Isbn = isbn;
            NomeAutor = nomeAutor;
            Preço = preço;
            DataPublicacao = dataPublicacao;
            ImagemDaCapa = imagemDaCapa;

            ValidarEntidade();

            AddNotifications(nomeAutor, isbn);
        }

        // ISBN, Autor, Nome, Preço, Data Publicação, Imagem da Capa
        public ISBN Isbn  { get; private set; }

        public Nome  NomeAutor { get; private set; }

        public string NomeLivro { get; private set; }

        public float Preço { get; private set; }

        public DateTime DataPublicacao { get; private set; }

        public string ImagemDaCapa { get; private set; }

        public override string ToString()
        {
            return this.NomeAutor.PrimeiroNome + " " + NomeAutor.Sobrenome;
        }

        public void AlterarLivro (ISBN isbn, Nome NomeAutor, float preço, DateTime DataPublicacao, string ImagemDaCapa)
        {

        }



        //public Livro(ISBN isbn, Nome autor, string nome, float preço, DateTime dataPublicacao, string imagemDaCapa)
        //{
        //    Isbn = isbn;
        //    NomeAutor = autor;
        //    NomeLivro = nome;
        //    Preço = preço;
        //    DataPublicacao = dataPublicacao;
        //    ImagemDaCapa = imagemDaCapa;

        //    ValidarEntidade();

        //    AddNotifications(autor, isbn);

        //}
        private void ValidarEntidade()
        {
            new AddNotifications<Livro>(this)
                .IfNullOrInvalidLength(x => x.NomeLivro, 1, 100, Message.O_PREENCHIMENTO_CAMPO_X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Nome", "1", "100"));
        }


    }
}
