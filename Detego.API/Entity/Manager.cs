using System;

namespace Detego.API.Entity
{
    public class Manager
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
    }
}