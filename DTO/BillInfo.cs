using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        public int Id { get; set; }
        public int Id_Bill { get; set; }
        public string Id_Food { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }

        public BillInfo() { }
        public BillInfo(int id, int id_Bill, string id_Food, int count, float price)
        {
            Id = id;
            Id_Bill = id_Bill;
            Id_Food = id_Food;
            Count = count;
            Price = price;
        }

        public BillInfo(DataRow row)
        {
            Id = (int)Convert.ToInt32(row["id"].ToString());
            Id_Bill = (int)Convert.ToInt32(row["id_bill"].ToString());
            Id_Food = (string)row["id_food"].ToString();
            Count = (int)Convert.ToInt32(row["amount"].ToString());
            Price = (float)Convert.ToDouble(row["price"].ToString());

        }
    }
}
