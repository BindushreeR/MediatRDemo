﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorDemo.Models
{
    public class NotificationMessage: INotification
    {
        public string NotifyText { get; set; }
    }
}
