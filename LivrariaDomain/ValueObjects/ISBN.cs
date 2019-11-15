using LivrariaDomain.Entities.Base;
using prmToolkit.NotificationPattern;

namespace LivrariaDomain.ValueObjects
{
    public class ISBN : Notifiable
    {
        public string NumeroIsbn { get; set; }
    }
}
