using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public class Post
    {
        private List<Post> posts;
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Post(string content)
        {
            Content = content;
            Date = DateTime.Now;
        }

        public void CreatePost(string content)
        {
            posts.Add(new Post(content));
        }
    }
}
