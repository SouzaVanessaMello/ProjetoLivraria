using System;
using System.Collections.Generic;
using LivrariaDomain.Arguments.BaseResponse;
using LivrariaDomain.Arguments.Livro;
using LivrariaDomain.Entities;
using LivrariaDomain.Interfaces.Repositories;
using LivrariaDomain.Interfaces.Services;
using LivrariaDomain.Resources;
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
            if (request == null) { 
                AddNotification("Adicionar", Message.E_OBRIGATORIO_PREENCHIMENTO_TODOS_CAMPOS.ToFormat("AdicionarLivroRequest"));
                return null;
            }

            var livro = new Livro (request.Isbn, request.Nome, request.Preço, request.PrimeiroNomeAutor, request.UltimoNomeAutor);
        }


        BaseResponse IServicoLivro.AlterarLivro(AlterarLivroRequest request)
        {
            throw new NotImplementedException();
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
