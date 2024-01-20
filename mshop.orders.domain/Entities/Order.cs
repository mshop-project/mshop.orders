using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mshop.orders.domain.Entities
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string ClientEmail { get; set; } = null!;

        public List<string> IdProducts { get; set; } = null!;

        public decimal TotalPriceBeforeDiscount { get; set; }

        public decimal TotalPriceAfterDiscount { get; set; } 
        public decimal Discount { get; set; }
    }
}
