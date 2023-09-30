using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return TableDAL.Instance.GetListTable();
        }

        public bool CheckTableExistsBill(int idTable)
        {
            return TableDAL.Instance.CheckTableExistsBill(idTable);
        }
    }

}
