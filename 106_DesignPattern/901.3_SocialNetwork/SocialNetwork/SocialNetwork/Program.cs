using System.Text.RegularExpressions;
using CLSocialNetwork;

SocialNetwork socialNetwork = new SocialNetwork();

// Créer quelques utilisateurs
User user1 = new User("John", 30);
User user2 = new User("Jane", 25);
User user3 = new User("Alice", 22);

// Créer quelques groupes
CLSocialNetwork.Group group1 = new CLSocialNetwork.Group("Tech Enthusiasts", "A group for tech lovers");
CLSocialNetwork.Group group2 = new CLSocialNetwork.Group("Fitness Club", "A group for fitness enthusiasts");

// Ajouter les utilisateurs et les groupes au réseau social
socialNetwork.RegisterUser(user1);
socialNetwork.RegisterUser(user2);
socialNetwork.RegisterUser(user3);
socialNetwork.CreateGroup(group1);
socialNetwork.CreateGroup(group2);

// Ajouter des utilisateurs aux groupes
socialNetwork.AddUserToGroup(user1, group1);
socialNetwork.AddUserToGroup(user2, group1);
socialNetwork.AddUserToGroup(user2, group2);
socialNetwork.AddUserToGroup(user3, group2);

// Afficher les utilisateurs et les groupes du réseau social
socialNetwork.DisplayUsersAndGroups();

// Exemple de publication dans un groupe avec vérification des autorisations
Console.WriteLine("\n-- Posting in a Group --");
PostProxy post1 = new PostProxy(user1, "Hello, everyone! How are you?");
post1.CreatePost(post1.Content);

PostProxy post2 = new PostProxy(user2, "Excited to announce our upcoming event!");
post2.CreatePost(post2.Content);
