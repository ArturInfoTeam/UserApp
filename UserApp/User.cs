using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    class User
    {
        public int id { get; set; }

        private string ID, email,pass;

        public string Login 
        {
            get { return ID;  }
            set { ID = value; }
        }
        public string Email 
        {
            get { return email;  }
            set { email = value; }
        }
        public string Pass 
        {
            get { return pass;  }
            set { pass = value; }
        }

        public User() { }

        public User(string login, string email, string pass) 
        {
            this.ID = login;
            this.email = email;
            this.pass = pass;
        }
    }
}
