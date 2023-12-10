using DAL.UseCase;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public Object GetListTable()
        {

            ResponseTable res = new ResponseTable();
            try
            {
                List<Table> list = new List<Table>();
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
                foreach (DataRow item in data.Rows)
                {
                    Table table = new Table(item);
                    list.Add(table);
                }
                res.error = list.Count > 0 ? false : true;
                res.message = "";
                res.data = list;
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }

        public Object CheckTableExistsBill(int idTable)
        {
            Response res = new Response();
            try
            {
                
                string query = string.Format("SELECT * FROM Bill WHERE id_table={0} AND status_bill=0", idTable);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                res.error = data.Rows.Count > 0 ? false : true;
                res.message = "";
                return res;
            } catch (Exception ex)
            {
                res.error= true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }

        public Object InsertTable()
        {
            Response res = new Response();
            try
            {
                string countQuery = string.Format("SELECT * FROM dbo.TableFood");
                DataTable countTable = DataProvider.Instance.ExecuteQuery(countQuery);

                string name = "Bàn " + (countTable.Rows.Count + 1).ToString();
                string query = string.Format("INSERT dbo.TableFood (table_name) values (N'{0}')", name);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                res.error = result > 0 ? false : true;
                res.message = "";
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }

        public Object DeleteTable(int idTable)
        {
            Response res = new Response();
            try
            {
                
                String query = string.Format("Delete from dbo.TableFood where id={0}", idTable);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                res.error = result > 0 ? false : true;
                res.message = "";
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                Logger.WriteLog(ex.Message);
                return res;
            }
        }
    }
}
