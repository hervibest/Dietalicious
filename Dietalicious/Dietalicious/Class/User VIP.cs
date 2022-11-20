using System.Collections.Generic;
using System;
namespace Dietalicious
{
    public class User_VIP : User //Class yang berisikan tentang user bentuk Inheritance + Polymorphism
    {
        

        public User_VIP(string Username, string Pass) : base(Username, Pass)
        {

            this.userName = Username;

            this.password = Pass;
        }
        public override string getUserName()
        {
            return userName;
        }
        public override void login()
        {

        }
        public override void addFavourite()
        {

        }
    }
}