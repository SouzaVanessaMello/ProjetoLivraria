﻿using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaDomain.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }
        //public Email(string endereco)
        //{
        //    Endereco = endereco;

        //    new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, Message.X0_INVALIDO.ToFormat("E-mail"));
        //}

        public string Endereco { get; private set; }
    }
}
