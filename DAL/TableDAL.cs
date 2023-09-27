using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableDAL
    {
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get { if (instance == null) instance = new TableDAL(); return TableDAL.instance; }
            private set { TableDAL.instance = value; }
        }
        private TableDAL() { }

        public List<Table> GetListTable()
        {
            List<Table> list = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }
            return list;
        }
    }
}
