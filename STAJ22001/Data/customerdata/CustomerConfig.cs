using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace STAJ22001.Data.customerdata;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    //database data specifications are done in this class instead of in customer class to keep it cleaner
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        //not nullable: .IsRequired
        builder.HasKey(x => x.CustomerId);
        builder.Property(x => x.ServiceName).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.Path).IsRequired();
        builder.Property(x => x.QueryString);
        builder.Property(x => x.RequestBody);
        builder.Property(x => x.Header);
        builder.Property(x => x.ResponseBody);
        builder.Property(x => x.IsEnabled).IsRequired();
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.CreatedBy);
        builder.Property(x => x.UpdatedDate);
        builder.Property(x => x.UpdatedBy);

    }
}

