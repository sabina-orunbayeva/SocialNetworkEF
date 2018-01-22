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
    public class UserPostConfiguration : EntityTypeConfiguration<UserPost>
    {
        public UserPostConfiguration()
        {
            HasKey(p => p.PostId);

            Property(p => p.PostId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Content)
                .HasMaxLength(1000)
                .IsRequired();

            HasRequired(p => p.UserCreator)
                .WithMany(p => p.PrivatePosts)
                .HasForeignKey(p => p.UserCreatorId);
        }
    }
}
