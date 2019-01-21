using System.Threading;
using System.Threading.Tasks;
using Detego.API.Hubs;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Detego.API.Application.Stores.Notifications
{
    public class StoreCreatedNotify : INotificationHandler<StoreCreatedEvent>
    {
        private readonly IHubContext<NotificationHub> notifyHub;

        public StoreCreatedNotify(IHubContext<NotificationHub> notifyHub)
        {
            this.notifyHub = notifyHub;
        }

        public Task Handle(StoreCreatedEvent notification, CancellationToken cancellationToken)
        {
            //TODO: Inject SignalR hub add notify all subscribers about changes

            

            return Task.CompletedTask;
        }
    }
}