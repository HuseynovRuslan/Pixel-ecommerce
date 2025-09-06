using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pixel.WebUI.Models.Entities;



namespace Pixel.WebUI.Models.Persistences.Configuration
{


    public class SizeEntityConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(m=>m.Id).UseIdentityColumn(1,1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired(); 
            builder.Property(m => m.shortName).HasColumnType("varchar").HasMaxLength(5).IsRequired(); 

            builder.ConfigureAsAuditable();

            builder.HasKey(m => m.Id);
            builder.ToTable("Sizes");
        }
    }
}
