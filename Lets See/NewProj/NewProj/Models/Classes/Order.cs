﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewProj.Classes
{
    [Table("Order")]
    [Index(nameof(CartID), Name = "IX_Order_CartID")]
    public partial class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int ID { get; set; }
        public int TotalPrice { get; set; }
        public DeliveryStatus Status { get; set; }
        public int? CartID { get; set; }

        [ForeignKey(nameof(CartID))]
        [InverseProperty("Orders")]
        public virtual Cart Cart { get; set; }
        [InverseProperty(nameof(Product.Order))]
        public virtual ICollection<Product> Products { get; set; }
       
    }
    public enum DeliveryStatus { Pending, Dispatched, Delivered }
}