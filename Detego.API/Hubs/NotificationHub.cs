using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace Detego.API.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly ILogger<NotificationHub> _logger;

        public NotificationHub(ILogger<NotificationHub> logger)
        {
            _logger = logger;
        }

        public override Task OnConnectedAsync()
        {
            _logger.LogDebug("!!!!! Подключени !!!!!");
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            _logger.LogDebug("!!!!! Отключен !!!!!");
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMsg(string message)
        {
            await Clients.All.SendAsync(nameof(SendMsg), message);
        }

        public async Task Test()
        {
            await Clients.All.SendAsync(nameof(Test));
        }

        public async Task StoreListChanged(CancellationToken cancellationToken)
        {
            await Clients.All.SendAsync(nameof(StoreListChanged), cancellationToken);
        }

        public async Task CharacteristicChanged(Guid storeId, CancellationToken cancellationToken)
        {
            await Clients.All.SendAsync(nameof(CharacteristicChanged), storeId, cancellationToken);
        }
    }
}