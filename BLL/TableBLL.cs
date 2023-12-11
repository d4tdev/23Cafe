using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class TableBLL
    {
        private static TableBLL instance;
        public static TableBLL Instance
        {
            get { if (instance == null) instance = new TableBLL(); return TableBLL.instance; }
            private set { TableBLL.instance = value; }
        }

        public TableBLL() { }

        public List<Table> GetListTable()
        {
            ResponseTable res = (ResponseTable)TableDAL.Instance.GetListTable();
            if (res.error == false) return res.data;
            else return null;
        }

        public bool CheckTableExistsBill(int idTable)
        {
            if ( string.IsNullOrEmpty(idTable.ToString()) || string.IsNullOrWhiteSpace(idTable.ToString()))
            {
                return false;
            }
            Response res = (Response)TableDAL.Instance.CheckTableExistsBill(idTable);
            if (res.error == false) return true;
            else return false;
        }
        public bool InsertTable()
        {
            Response res = (Response)TableDAL.Instance.InsertTable();
            if (res.error == false) return true;
            else return false;
        }
        public bool DeleteTable(int idTable)
        {
            if (string.IsNullOrEmpty(idTable.ToString()) || string.IsNullOrWhiteSpace(idTable.ToString()))
            {
                return false;
            }
            Response res = (Response)TableDAL.Instance.DeleteTable(idTable);
            if (res.error == false) return true;
            else return false;
        }
    }

}
