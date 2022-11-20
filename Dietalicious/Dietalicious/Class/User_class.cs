using System.Collections.Generic;
using System;
namespace Dietalicious
{
    public class User //Class yang berisikan tentang user
    {
        private int id { get; set; }
        protected string userName { get; set; }
        protected string email { get; set; }
        protected string password { get; set; }
        protected List<string> favourite_list = new List<string>();

        public User(string Username, string Pass)
        {

            userName = Username;

            password = Pass;
        }
        public virtual string getUserName()
        {
            return userName;
        }
        public virtual void login()
        {

        }
        public virtual void addFavourite()
        {

        }
    }
}