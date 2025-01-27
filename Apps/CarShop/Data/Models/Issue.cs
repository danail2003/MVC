﻿namespace CarShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Issue
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Description { get; set; }

        public bool IsFixed { get; set; }

        [ForeignKey(nameof(Car))]
        public string CarId { get; set; }

        public Car Car { get; set; }
    }
}
