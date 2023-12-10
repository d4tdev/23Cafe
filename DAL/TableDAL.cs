using DAL.UseCase;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableDAL : TableUseCase
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

        public bool CheckTableExistsBill(int idTable)
        {
            string query = string.Format("SELECT * FROM Bill WHERE id_table={0} AND status_bill=0", idTable);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool InsertTable(int idTable)
        {
            String name = idTable.ToString();
            string query = string.Format("INSERT dbo.TableFood (id, table_name) values ({0}, N'Bàn {1}')", idTable, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTable(int idTable)
        {
            String query = string.Format("Delete from dbo.TableFood where id={0}", idTable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
