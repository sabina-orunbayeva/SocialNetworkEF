using SocialNetworkEF.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Configurations
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(p => p.UserId);

            Property(p => p.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Login)
                .HasMaxLength(20).IsRequired();

            Property(p => p.FirstName)
                .HasMaxLength(50).IsRequired();

            Property(p => p.LastName)
                .HasMaxLength(50).IsRequired();

            Property(p => p.Status)
                .HasMaxLength(500).IsRequired();

            Property(p => p.City)
                .HasMaxLength(50).IsRequired();

            Property(p => p.Country)
                .HasMaxLength(50).IsRequired();

            Property(p => p.MaritalStatus).IsRequired();

            Property(p => p.BirthDate).IsRequired();

            HasMany(p => p.Groups)
                .WithMany(p => p.Users)
                .Map(m =>
                {
                    m.MapLeftKey("UserID");
                    m.MapRightKey("GroupID");
                    m.ToTable("UserGroup");
                });
        }
    }
}
