﻿using Dapper.Contrib.Extensions;

namespace CoffeeShop_Product_List.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int inventory { get; set; }
        public string category { get; set; }

    }
}
