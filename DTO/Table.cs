using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int StatusTable { get; set; }
        public Table() { }
        public Table(int id, string tableName, int statusTable)
        {
            this.Id = id;
            this.TableName = tableName;
            this.StatusTable = statusTable;
        }
        public Table(DataRow row)
        {
            this.Id = (int) Convert.ToInt32(row["id"].ToString());
            this.StatusTable = (int)Convert.ToInt32(row["status_table"].ToString());
            this.TableName = (string)row["table_name"].ToString();
        }
    }
}
