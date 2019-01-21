using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Detego.API.Hubs
{
    public class NotificationHub : Hub
    {
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