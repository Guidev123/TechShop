﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Notifications
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Notify(Notification notification);
    }
}
