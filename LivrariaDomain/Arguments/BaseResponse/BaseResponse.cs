using LivrariaDomain.Resources;
using System;

namespace LivrariaDomain.Arguments.BaseResponse
{
    public class BaseResponse
    {
       
        public string Mensagem { get; set; }
       

        public static explicit operator BaseResponse(string mensagem)
        {
            return new BaseResponse()
            {
                Mensagem = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}
