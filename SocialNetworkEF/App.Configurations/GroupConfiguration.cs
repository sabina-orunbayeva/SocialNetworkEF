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
    public class GroupConfiguration:EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            HasKey(p => p.GroupId);

            Property(p => p.GroupId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.GroupName)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
