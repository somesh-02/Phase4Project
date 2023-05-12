﻿namespace corePizzaProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int AvailableQuantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
