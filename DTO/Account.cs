using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username, password, display_name;
        private int role;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Display_Name
        {
            get { return display_name; }
            set { display_name = value; }
        }
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        public Account(string username, string password, string display_name, int role)
        {
            this.Username = username;
            this.Password = password;
            this.Display_Name = display_name;
            this.Role = role;
        }

        public Account(DataRow row)
        {
            this.Username = (string)row["username"];
            this.Password = row["password"].ToString();
            this.Display_Name = (string)row["display_name"];
            this.Role = (int)Convert.ToInt32(row["role"].ToString());
        }
    }
}
