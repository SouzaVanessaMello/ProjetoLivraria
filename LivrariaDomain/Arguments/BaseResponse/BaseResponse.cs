using LivrariaDomain.Entities;
using LivrariaDomain.Resources;

namespace LivrariaDomain.Arguments.BaseResponse
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Mensagem = Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }
        public string Mensagem { get; set; }


        public static explicit operator BaseResponse(Livro entidade)
        {
            return new BaseResponse()
            {
                Mensagem = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
