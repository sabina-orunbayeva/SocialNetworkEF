using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public class CommentForGroupPost:Comment
    {
        public int PostId { get; set; }
        public GroupPost Post { get; set; }
        public CommentForGroupPost():base()
        {
            PostId = Post.PostId;
        }
    }
}
