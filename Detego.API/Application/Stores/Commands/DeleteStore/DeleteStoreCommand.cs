using System;
using MediatR;

namespace Detego.API.Application.Stores.Commands.DeleteStore
{
    public class DeleteStoreCommand : IRequest
    {
        public Guid StoreId { get; set; }
    }
}