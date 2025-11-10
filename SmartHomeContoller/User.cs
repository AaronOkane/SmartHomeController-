using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeContoller
{
    public class User
    {
        // private fields
        private int userId;
        private string user;
        private string password;
        private string contactInfo;
        private bool IsLoggedIn;

        // public properties 
        public int UserId
        {
            get { return UserId; }
            set { UserId = value; }
        }

        public string UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string isLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        // Constructor
        public User(int userId, 
            string username, 
            string password,
            string ContactInfo, 
            bool isLoggedIn
            )
        {
            UserId= userId;
            UserName= username;
            Password= password;
            ContactInfo= contactInfo;
            IsLoggedIn=isLoggedIn;
        }






        // Methods

        public bool login(string userName, String Password)
        {
            if (UserName == userName && password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login in successful");
            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine($"Login failed.Usser {userName} or pass word is incorrect");
            }
            return IsLoggedIn;
        } 
              public bool Logout()
        {
            // check if IsLogedin = true
            // if they are loggged in then log the user out
            if (IsLoggedIn)
            {
                isLoggedIn = false;
                Console.WriteLine("user is logged out successfully");

            }
            else 
            {
                Console.WriteLine("User is not logged in");
            }
            return IsLoggedIn;
        }
    }
}
    


