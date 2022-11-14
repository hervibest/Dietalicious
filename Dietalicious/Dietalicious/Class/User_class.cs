using System.Collections.Generic;
using System;
namespace Dietalicious
{
    public class User //Class yang berisikan tentang user
    {
        private int id { get; set; }
        private string userName { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private List<string> favourite_list = new List<string>();

        public User(string Username, string Pass)
        {

            userName = Username;

            password = Pass;
        }
        public string getUserName()
        {
            return userName;
        }
        public void login()
        {

        }
        public void addFavourite()
        {

        }
    }
}