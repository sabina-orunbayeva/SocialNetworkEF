using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public abstract class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }

        public int UserCreatorId { get; set; }
        public User UserCreator { get; set; }

        public Post()
        {
            UserCreatorId = UserCreator.UserId;
        }
    }
}
