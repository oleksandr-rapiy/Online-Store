﻿using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
    }
}
