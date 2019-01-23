using Detego.API.Hubs;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace Detego.API.Application.Stores.Notifications
{
    public class StoreListUpdateNotify : INotificationHandler<StoreListUpdateEvent>
    {
        private readonly IHubContext<NotificationHub, INotificationHub> _hubContext;

        public StoreListUpdateNotify(IHubContext<NotificationHub, INotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task Handle(StoreListUpdateEvent notification, CancellationToken cancellationToken)
        {
            await _hubContext.Clients.All.StoreListUpdateNotify();
        }
    }
}