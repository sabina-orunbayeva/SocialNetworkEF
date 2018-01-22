using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public enum MaritalStatus
    {
        ActivelyLooking,
        Free,
        Married,
        InARelationship
    }

    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<UserPost> PrivatePosts { get; set; }
        public ICollection<GroupPost> GroupPosts { get; set; }
        public ICollection<CommentForGroupPost> CommentsForGroupPost { get; set; }
        public ICollection<CommentForUserPost> CommentsForUserPost { get; set; }

        public User()
        {
            PrivatePosts = new List<UserPost>();
            GroupPosts = new List<GroupPost>();
            Groups = new List<Group>();
            CommentsForGroupPost = new List<CommentForGroupPost>();
            CommentsForUserPost = new List<CommentForUserPost>();
        }
    }
}
