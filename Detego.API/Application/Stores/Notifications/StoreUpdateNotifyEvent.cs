using MediatR;
using System;

namespace Detego.API.Application.Stores.Notifications
{
    public class StoreUpdateEvent : INotification
    {
        public Guid StoreId { get; set; }
    }
}