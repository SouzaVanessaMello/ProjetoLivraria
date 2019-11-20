using LivrariaDomain.Arguments.BaseResponse;
using LivrariaDomain.Arguments.Livro;
using LivrariaDomain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace LivrariaDomain.Interfaces.Services
{
    public interface IServicoLivro : IServiceBase
    {
        IEnumerable<LivroResponse> ListarLivro();

        AdicionarLivroResponse AdicionarLivro(AdicionarLivroRequest request);

        BaseResponse AlterarLivro(AlterarLivroRequest request);

        BaseResponse ExcluirLivro(Guid id);
    }
}
