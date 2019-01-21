using MediatR;

namespace Detego.API.Application.Stores.Commands.CreateStore
{
    public class CreateStoreCommand : IRequest
    {
        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string ContactEmail { get; set; }
    }
}