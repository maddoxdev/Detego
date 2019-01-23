using Detego.API.Hubs;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace Detego.API.Application.Stores.Notifications
{
    public class StoreUpdateNotify : INotificationHandler<StoreUpdateEvent>
    {
        private readonly IHubContext<NotificationHub, INotificationHub> _hubContext;

        public StoreUpdateNotify(IHubContext<NotificationHub, INotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public async Task Handle(StoreUpdateEvent notification, CancellationToken cancellationToken)
        {
            await _hubContext.Clients.All.StoreUpdateNotify(notification.StoreId);
        }
    }
}