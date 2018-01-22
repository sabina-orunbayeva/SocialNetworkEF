using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public class CommentForUserPost:Comment
    {
        public int PostId { get; set; }
        public UserPost Post { get; set; }
        public CommentForUserPost():base()
        {
            PostId = Post.PostId;
        }
    }
}
