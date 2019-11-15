using LivrariaDomain.Entities.Base;
using prmToolkit.NotificationPattern;

namespace LivrariaDomain.ValueObjects
{
    public class Nome : Notifiable
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}
