using System;
using System.Linq.Expressions;
using Detego.API.Entity;

namespace Detego.API.Application.Stores.Models
{
    public class StoreViewModelDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string ContactEmail { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerContactEmail { get; set; }

        public static Expression<Func<Store, StoreViewModelDto>> Projection
        {
            get
            {
                return s => new StoreViewModelDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    CountryCode = s.CountryCode,
                    ContactEmail = s.ContactEmail,
                    ManagerFirstName = s.Manager.FirstName,
                    ManagerLastName = s.Manager.LastName,
                    ManagerContactEmail = s.Manager.ContactEmail
                };
            }
        }

    }
}
