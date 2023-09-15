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
        private string username, password, display_name, phone;
        private int role, basic_salary;

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
        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        public int Basic_Salary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }
        public Account(string username, string password, string display_name, string phone, int basic_salary, int role)
        {
            this.Username = username;
            this.Password = password;
            this.Display_Name = display_name;
            this.Phone = phone;
            this.Basic_Salary = basic_salary;
            this.Role = role;
        }

        public Account(DataRow row)
        {
            this.Username = (string)row["username"];
            this.Password = row["password"].ToString();
            this.Display_Name = (string)row["display_name"];
            this.Phone = row["phone"].ToString();
            this.Basic_Salary = (int)Convert.ToInt32(row["basic_salary"].ToString());
            this.Role = (int)Convert.ToInt32(row["role"].ToString());
        }
    }
}
