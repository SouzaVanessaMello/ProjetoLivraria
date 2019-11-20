using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Message = LivrariaDomain.Resources.Message;

namespace LivrariaDomain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            new AddNotifications<Nome>(this)
                    .IfNullOrInvalidLength(i => i.PrimeiroNome, 2, 10, Message.O_PREENCHIMENTO_CAMPO_X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro nome", "2", "10"))
                    .IfNullOrInvalidLength(i => i.Sobrenome, 2, 50, Message.O_PREENCHIMENTO_CAMPO_X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Sobrenome", "2", "50"));
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
