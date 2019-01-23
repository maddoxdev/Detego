using Detego.API.Application.Stores.Notifications;
using Detego.API.Context;
using Detego.API.Entity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Detego.API.Application.Stores.Commands.DeleteStore
{
    public class DeleteStoreHandler : IRequestHandler<DeleteStoreCommand>
    {
        private readonly IMediator _mediator;
        private readonly StoreContext _context;

        public DeleteStoreHandler(IMediator mediator, StoreContext context)
        {
            _mediator = mediator;
            _context = context;
        }
        public async Task<Unit> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            #region [Use repository pattern]
            var store = new Store { Id = request.StoreId };
            _context.Attach(store);
            _context.Remove(store);
            await _context.SaveChangesAsync();
            #endregion

            await _mediator.Publish(new StoreListUpdateEvent());
            return Unit.Value;
        }
    }
}