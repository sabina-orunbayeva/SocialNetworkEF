using SocialNetworkEF.App.Configurations;
using SocialNetworkEF.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<GroupPost> GroupPosts { get; set; }
        public DbSet<CommentForUserPost> CommentsForUserPost { get; set; }
        public DbSet<CommentForGroupPost> CommentsForGroupPost { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new UserPostConfiguration());
            modelBuilder.Configurations.Add(new GroupPostConfiguration());
            modelBuilder.Configurations.Add(new CommentForUserPostConfiguration());
            modelBuilder.Configurations.Add(new CommentForGroupPostConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext() : base("name=ConnectionString")
        {

        }
    }
}
