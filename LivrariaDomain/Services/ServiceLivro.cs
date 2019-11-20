using System;
using System.Collections.Generic;
using LivrariaDomain.Arguments.BaseResponse;
using LivrariaDomain.Arguments.Livro;
using LivrariaDomain.Entities;
using LivrariaDomain.Interfaces.Repositories;
using LivrariaDomain.Interfaces.Services;
using LivrariaDomain.Resources;
using LivrariaDomain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace LivrariaDomain.Services
{
    public class ServiceLivro : Notifiable, IServicoLivro
    {
        private readonly IRepositoryLivro _repositoryLivro;

        public ServiceLivro(IRepositoryLivro repositoryLivro)
        {
            _repositoryLivro = repositoryLivro;    
        }

        AdicionarLivroResponse IServicoLivro.AdicionarLivro(AdicionarLivroRequest request)
        {
            var nomeAutor = new Nome(request.PrimeiroNomeAutor, request.SobrenomeAutor);
            var isbn = new ISBN(request.Isbn);

            Livro livro = new Livro(isbn, nomeAutor, request.NomeLivro, request.Preço, request.DataPublicacao, request.ImagemDaCapa);

            AddNotifications(nomeAutor, isbn);

            if (_repositoryLivro.Exist(x=>x.Isbn.NumeroIsbn == request.Isbn))
            {
                AddNotification("ISBN", Message.JA_EXISTE_UM_LIVRO_COM_ISBN_X0.ToFormat("ISBN", request.Isbn));
            }
            if (this.IsInvalid())
            {
                return null;
            }
            livro = _repositoryLivro.ToAdd(livro);

            return (AdicionarLivroResponse)livro;
        }


        BaseResponse IServicoLivro.AlterarLivro(AlterarLivroRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarLivroRequest", Message.E_OBRIGATORIO_PREENCHIMENTO_DE_X0.ToFormat("AlterarJogadorRequest"));
            }

            Livro livro = _repositoryLivro.GetById(request.Id);

            if (livro == null)
            {
                AddNotification("Id", Message.DADOS_NAO_ENCONTRADOS);
                return null;
            }
            if (livro.Isbn.NumeroIsbn == request.Isbn)
            {
                AddNotification("ISBN", Message.JA_EXISTE_UM_LIVRO_COM_ISBN_X0.ToFormat("ISBN", request.Isbn));
            }
            if (this.IsInvalid())
            {
                return null;
            }

            var nomeAutor = new Nome(request.PrimeiroNomeAutor, request.SobrenomeAutor);
            var isbn = new ISBN(request.Isbn);
            new Livro(isbn, nomeAutor, request.NomeLivro, request.Preço, request.DataPublicacao, request.ImagemDaCapa);

            AddNotifications(nomeAutor, isbn);



        }

        BaseResponse IServicoLivro.ExcluirLivro(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<LivroResponse> IServicoLivro.ListarLivro()
        {
            throw new NotImplementedException();
        }
    }
}
