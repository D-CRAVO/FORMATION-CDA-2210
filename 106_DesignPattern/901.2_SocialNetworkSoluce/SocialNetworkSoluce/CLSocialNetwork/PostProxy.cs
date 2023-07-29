using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public class PostProxy : Post
    {
        private User user;

        public PostProxy(User user, string content) : base(content)
        {
            this.user = user;
        }

        public new void CreatePost(string content)
        {
            if(user.Followers >= 100)
            {
                base.CreatePost(content);
            }
            else
            {
                Console.WriteLine($"[{user.Name}] - You don't have enougth followers")
            }
        }
    }
}
