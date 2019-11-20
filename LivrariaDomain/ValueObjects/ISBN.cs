using LivrariaDomain.Entities.Base;
using LivrariaDomain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace LivrariaDomain.ValueObjects
{
    public class ISBN : Notifiable
    {
        public ISBN(string numeroIsbn)
        {
            NumeroIsbn = numeroIsbn;

            new AddNotifications<ISBN>(this).IfNullOrInvalidLength(i => i.NumeroIsbn, 13, 13, Message.O_PREENCHIMENTO_CAMPO_X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat());

        }

        public string NumeroIsbn { get; private set; }
    }
}
