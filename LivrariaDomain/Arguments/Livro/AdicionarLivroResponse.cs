using System;

namespace LivrariaDomain.Arguments.Livro
{
    public class AdicionarLivroResponse : BaseResponse.BaseResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarLivroResponse(Entities.Livro entity)
        {
            return new AdicionarLivroResponse()
            {
                Id = entity.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
    
}
