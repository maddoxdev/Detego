using System;

namespace Detego.API.Entity
{
    public class Characteristic
    {
        public int BackStore { get; set; }
        public int FrontStore { get; set; }
        public int ShopWindow { get; set; }
        public float Accuracy { get; set; }
        public float Availability { get; set; }
        public int MeanAge { get; set; }

        public Guid StoreId { get; set; }
        public Store Store { get; set; }
    }
}