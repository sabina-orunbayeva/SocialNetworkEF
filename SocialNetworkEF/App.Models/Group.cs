using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkEF.App.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<GroupPost> Posts { get; set; }

        public Group()
        {
            Users = new List<User>();
            Posts = new List<GroupPost>();
        }
    }
}
