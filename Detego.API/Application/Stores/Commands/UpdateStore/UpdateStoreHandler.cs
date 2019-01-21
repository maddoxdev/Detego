using System.Threading;
using System.Threading.Tasks;
using Detego.API.Application.Stores.Notifications;
using Detego.API.Context;
using Detego.API.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Detego.API.Application.Stores.Commands.UpdateStore
{
    public class UpdateStoreHandler : IRequestHandler<UpdateStoreCommand, Store>
    {
        private readonly IMediator _mediator;
        private readonly StoreContext _context;

        public UpdateStoreHandler(IMediator mediator, StoreContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        public async Task<Store> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            #region [Use repository pattern]
            var store = await _context.Stores
                .Include(s => s.Manager)
                .FirstAsync(s => s.Id == request.StoreId);

            // Can be use AutoMapper
            store.ContactEmail = request.ContactEmail;
            store.Name = request.Name;
            store.CountryCode = request.CountryCode;
            store.Manager.FirstName = request.ManagerFirstName;
            store.Manager.LastName = request.ManagerLastName;
            store.Manager.ContactEmail = request.ManagerContactEmail;
            
            _context.Entry(store).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            #endregion

            await _mediator.Publish(new StoreUpdateEvent {StoreId = store.Id});

            return store;
        }
    }
}