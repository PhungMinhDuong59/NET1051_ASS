﻿using System.ComponentModel.DataAnnotations;

namespace NET1051_ASS.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }

        [Required]
        public int CartID { get; set; }
        public virtual Cart Cart { get; set; }

        public int? FoodItemID { get; set; }
        public virtual FoodItem FoodItem { get; set; }

        public int? ComboID { get; set; }
        public virtual Combo Combo { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0.")]
        public decimal Price { get; set; }
    }
}
