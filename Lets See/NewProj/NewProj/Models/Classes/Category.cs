﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewProj.Classes
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [InverseProperty(nameof(Product.CategoryNavigation))]
        public virtual ICollection<Product> Products { get; set; }
    }
}