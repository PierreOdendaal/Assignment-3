using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Users
    {
        private string name;
        private string password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public Users(string name, string password)
        {
            this.name = name;
            this.password = password;
            
        }

        public Users()
        {
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, password);
        }

        public List<Users> PopulateUsers()
        {
            List<Users> users = new List<Users>();
            Filehandler fh = new Filehandler();
            List<string> rawData = fh.ReadData("Person.txt");

            foreach (string item in rawData)
            {
                string[] data = item.Split(',');
                users.Add(new Users(data[0], data[1]));
            }

            return users;
        }
    }
}
