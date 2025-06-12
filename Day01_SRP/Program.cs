using System;
using static System.Collections.Specialized.BitVector32;

namespace Day01_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            userService.CreateUser();

           //Similarly for other services 

            Console.WriteLine("Done!");
        }
    }



    // Bad Approach as it voilates SRP - Single Responsible Principle
    public class UserManager
    {
        public void CreateUser()
        {

        }

        public void SendMail()
        {

        }

        public void LogAction()
        {

        }
    }



    // This is Better approach (As it Follows SRP)
    public class UserService
    {
        public void CreateUser()
        {
        }
    }

    public class MailService
    {
        public void SendMail()
        {
        }
    }

    public class LogService
    {
        public void LogAction()
        {
        }
    }
}
