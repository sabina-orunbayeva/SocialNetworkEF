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
    public class GroupPostConfiguration: EntityTypeConfiguration<GroupPost>
    {
        public GroupPostConfiguration():base()
        {
            HasKey(p => p.PostId);

            Property(p => p.PostId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Content)
                .HasMaxLength(1000)
                .IsRequired();

            HasRequired(p => p.UserCreator)
                .WithMany(gp => gp.GroupPosts)
                .HasForeignKey(p => p.UserCreatorId);

            HasRequired(p => p.Group)
                .WithMany(gp => gp.Posts)
                .HasForeignKey(p => p.GroupId);
        }
    }
}
