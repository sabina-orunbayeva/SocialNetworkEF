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
    public class CommentForUserPostConfiguration:EntityTypeConfiguration<CommentForUserPost>
    {
        public CommentForUserPostConfiguration()
        {
            HasKey(p => p.CommentId);

            Property(p => p.CommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Content)
                .HasMaxLength(1000)
                .IsRequired();

            HasRequired(p => p.User)
                .WithMany(p => p.CommentsForUserPost)
                .HasForeignKey(p => p.UserId);

            HasRequired(p => p.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.PostId);
        }
    }
}
