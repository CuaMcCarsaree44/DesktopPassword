using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop_Password.Factory
{
    class User
    {
        private string UserID, password;

        public string ID { get { return this.UserID; } set { this.UserID = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }

        public User UserFactory(string aidi, string pass)
        {
            User Person = new User();
            Person.ID = aidi;
            Person.Password = pass;
            return Person;
        }
    }
}
