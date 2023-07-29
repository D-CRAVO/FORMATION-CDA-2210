using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    internal class SociaNetwork
    {
        private List<User> users;
        private List<Group> groups;

        public SocialNetwork()
        {
            users = new List<User>();
            groups = new List<Group>();
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void CreateGroup(Group group)
        {
            groups.Add(group);
        }

        public void AddUserToGroup(User user, Group group)
        {
            group.Add(user);
        }

        public void RemoveUserFromGroup(User user, Group group)
        {
            group.Remove(user);
        }

        public void DisplayUsersAndGroups()
        {
            Console.WriteLine("Registered Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"- {user.Name} (Followers: {user.Followers})");
            }

            Console.WriteLine("\nGroups:");
            foreach (var group in groups)
            {
                group.Display(1);
            }
        }
    }
}
