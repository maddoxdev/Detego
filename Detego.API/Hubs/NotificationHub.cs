using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace Detego.API.Hubs
{
    public class NotificationHub : Hub<INotificationHub>
    {
        private readonly ILogger<NotificationHub> _logger;

        public NotificationHub(ILogger<NotificationHub> logger)
        {
            _logger = logger;
        }

        public async Task StoreUpdateNotify(Guid storeId)
        {
            
            await Clients.All.StoreUpdateNotify(storeId);
        }

        public async Task StoreListUpdateNotify()
        {
            await Clients.All.StoreListUpdateNotify();
        }
    }

    public interface INotificationHub
    {
        Task StoreUpdateNotify(Guid storeId);
        Task StoreListUpdateNotify();
    }
}