using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "898ced3e-6a9e-4825-99e0-7590da957c9e",
                    UserId = "306f5548-ee15-4d1c-b58d-381a1584c8c6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a4c957fa-cead-4047-be7b-fd8371023853",
                    UserId = "359gh148-ee15-4d1c-b58d-381a1584f2f9"
                }
            );
        }
    }
}
