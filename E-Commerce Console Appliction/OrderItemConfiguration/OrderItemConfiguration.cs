using E_Commerce_Console_Appliction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Console_Appliction.OrderItemConfiguration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(op=> new
            {
                op.OrderId,
                op.ProductId,
            });
            builder.HasOne(o => o.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o=>o.OrderId);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
