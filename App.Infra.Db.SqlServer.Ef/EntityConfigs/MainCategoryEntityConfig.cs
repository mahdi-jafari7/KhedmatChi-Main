using App.Domain.Core.Expert.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Ef.EntityConfigs
{
    public class MainCategoryEntityConfig : IEntityTypeConfiguration<MainCategory>
    {

        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            builder
                .HasKey(c => c.Id);
            builder
                .Property(c => c.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(c => c.Image)
                .HasMaxLength(4000);
            builder
                .Property(c => c.Description)
                .HasMaxLength(4000)
                .IsRequired();
            builder
                .Property(c => c.CreatedAt)
                .IsRequired();
            builder
                .Property(c => c.IsDeleted)
                .IsRequired();


            builder.HasData(
                new MainCategory { Id = 1, Title = "ساختمان", Image = "", CreatedAt = DateTime.Now, IsDeleted = false, Description = "" });

            
        }
    }
}
