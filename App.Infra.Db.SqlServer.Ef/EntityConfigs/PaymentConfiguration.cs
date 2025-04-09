using App.Domain.Core.Other_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Ef.EntityConfigs
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .IsRequired();

            
            builder.HasOne(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Expert)
                .WithMany()
                .HasForeignKey(p => p.ExpertId)
                .OnDelete(DeleteBehavior.NoAction);

            
            builder.HasOne(p => p.Service)
                .WithMany()
                .HasForeignKey(p => p.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }


}
