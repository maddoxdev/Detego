using System.Threading;
using System.Threading.Tasks;
using Detego.API.Application.Stores.Notifications;
using MediatR;

namespace Detego.API.Application.Stores.Commands.CreateStore
{
    public class CreateStoreHandler : IRequestHandler<CreateStoreCommand>
    {
        private readonly IMediator _mediator;

        public CreateStoreHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            //TODO: Inject DbContext and save data, alse call notify 

            await _mediator.Publish(new StoreCreatedEvent(), cancellationToken);

            return Unit.Value;
        }
    }
}