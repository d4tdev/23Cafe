using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public int Id { get; set; }
        public string Id_Table { get; set; }
        public int Status_Bill { get; set; }
        public DateTime Date_Checkout { get; set; }
        public double Total_Price { get; set; }

        public Bill() { }
        public Bill(int id, string id_Table, int status_Bill, DateTime date_Checkout, double total_Price)
        {
            this.Id = id;
            this.Id_Table = id_Table;
            this.Status_Bill = status_Bill;
            this.Date_Checkout = date_Checkout;
            this.Total_Price = total_Price;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)Convert.ToInt32(row["id"].ToString());
            this.Id_Table = (string)row["id_table"].ToString();
            this.Status_Bill = (int) Convert.ToInt32(row["status_bill"].ToString());
            this.Date_Checkout = (DateTime)Convert.ToDateTime(row["date_checkout"].ToString());
            this.Total_Price = (float)Convert.ToDouble(row["total_price"].ToString());
        }
    }
}
