﻿using System.ComponentModel.DataAnnotations;

namespace NET1051_ASS.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        public string Role { get; set; } = "customer";

        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; } = true;

        // Lazy loading
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
