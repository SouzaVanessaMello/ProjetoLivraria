using prmToolkit.NotificationPattern;
using System;

namespace LivrariaDomain.Entities.Base
{
    public abstract class BaseEntity : Notifiable
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
