using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public abstract class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Content { get; set; }

        public Comment()
        {
            UserId = User.UserId;
        }
    }
}
