using System;

namespace Detego.API.Entity
{
    public class Store
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string ContactEmail { get; set; }

        public Guid ManagerId { get; set; }

        public Manager Manager { get; set; }

        public Guid? CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }
    }
}