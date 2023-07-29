namespace CLSocialNetwork
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Followers { get; set; }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Followers = 0;
        }

        public void AddFollower()
        {
            Followers++;
        }

        public void RemoveFollower()
        {
            if (Followers >0)
                Followers--;
        }

        public void CreatePost(string content)
        {
            Console.WriteLine($"[{Name}] {content}");
        }
    }
}