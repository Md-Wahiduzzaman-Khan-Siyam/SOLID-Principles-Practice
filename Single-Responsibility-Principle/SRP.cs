using System;

namespace ConsoleApp1
{
    class SRP
    {
        public class User
        {
            public string Name { get; set; }
        }

        public class UserRepo
        {
            public void Save(User user)
            {
                Console.WriteLine($"{user.Name} saved");
            }
        }

        public class EmainService
        {
            public void SendWelcomeEmail(User user)
            {
                Console.WriteLine($"Email sent to {user.Name}");
            }
        }
        
        static void Main(string[] args)
        {
            User man = new User();
            man.Name = "siyam";
            UserRepo repo = new UserRepo();
            repo.Save(man);
            EmainService email = new EmainService();
            email.SendWelcomeEmail(man);
        }
    }
}