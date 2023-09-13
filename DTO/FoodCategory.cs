using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodCategory
    {
        /**
         * Class Food
         * id INT
         * name NVARCHAR(100)
         */
        private int id;
        private string name;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public FoodCategory(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public FoodCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
