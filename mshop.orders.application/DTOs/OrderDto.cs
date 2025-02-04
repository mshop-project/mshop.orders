﻿namespace mshop.orders.application.DTOs
{
    public class OrderDto
    {
        public string? Id { get; set; }
        public string? ClientEmail { get; set; } 
        public List<string>? IdProducts { get; set; } 
        public decimal? TotalPriceBeforeDiscount { get; set; }
        public decimal? TotalPriceAfterDiscount { get; set; }
        public decimal? DiscountPercentage { get; set; }
    }
}
