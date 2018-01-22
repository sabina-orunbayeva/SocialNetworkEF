using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public class GroupPost:Post
    {
        public int GroupId { get; set; }
        public Group Group { get; set;}

        public ICollection<CommentForGroupPost> Comments { get; set; }

        public GroupPost():base()
        {
            GroupId = Group.GroupId;
            Comments = new List<CommentForGroupPost>();
        }
    }
}
