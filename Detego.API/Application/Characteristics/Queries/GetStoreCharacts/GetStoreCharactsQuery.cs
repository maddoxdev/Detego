using System;
using Detego.API.Entity;
using MediatR;

namespace Detego.API.Application.Characteristics.Queries.GetStoreCharacts
{
    public class GetStoreCharactsQuery : IRequest<Characteristic>
    {
        public Guid StoreId { get; set; }
    }
}