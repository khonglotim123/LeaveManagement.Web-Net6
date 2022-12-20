using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "eeaf39c4-09ad-4f6b-b362-116ea241dfb8",
                    UserId= "eeaf39b4-02xa-4f6b-b586-116ea241dfb4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "eeag39b4-09dd-4f6b-b362-116ea241hgb8",
                    UserId = "eeaf39b4-09ad-4f6b-b586-116ea241dfb4"
                }
                );
        }
    }
}