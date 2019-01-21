using System;
using Detego.API.Entity;
using MediatR;

namespace Detego.API.Application.Stores.Commands.UpdateStore
{
    public class UpdateStoreCommand : IRequest<Store>
    {
        public Guid StoreId { get; set; }

        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string ContactEmail { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerContactEmail { get; set; }
    }
}