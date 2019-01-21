using System;
using MediatR;

namespace Detego.API.Application.Characteristics.Commands.UpdateCharatcs
{
    public class UpdateCharatcsCommand : IRequest
    {
        public Guid StoreId { get; set; }
        public Guid Id { get; set; }
        public int BackStore { get; set; }
        public int FrontStore { get; set; }
        public int ShopWindow { get; set; }
        public float Accuracy { get; set; }
        public float Availability { get; set; }
        public int MeanAge { get; set; }
    }
}