using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public class UserPost:Post
    {
        public ICollection<CommentForUserPost> Comments { get; set; }

        public UserPost():base()
        {
            Comments = new List<CommentForUserPost>();
        }
    }
}
