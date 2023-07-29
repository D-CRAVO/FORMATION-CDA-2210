using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSocialNetwork
{
    public class Group : ISocialEntity, IEnumerable<User>, IList<User>
    {
        private List<User> users;
        public string Name { get; set; }
        public string Description { get; set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public User this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Group(string name, string description)
        {
            Name = name;
            Description = description;
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public void Remove(User user)
        {
            users.Remove(user);
        }

        public void Display()
        {
            Console.WriteLine('-' + Name);

            foreach (var user in users)
            {
                user.Display();
            }
        }

        #region IEnumerator
        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IList
        public int IndexOf(User item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, User item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(User item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(User[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<User>.Remove(User item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
