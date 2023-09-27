using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL
    {
        private static BillBLL instance;
        public static BillBLL Instance
        {
            get { if (instance == null) instance = new BillBLL(); return BillBLL.instance; }
            private set { BillBLL.instance = value; }
        }
        public BillBLL() { }
        public List<Bill> GetAllListBill()
        {
            return BillDAL.Instance.GetAllListBill();
        }

        public bool InsertBill(int idTable)
        {
            return BillDAL.Instance.InsertBill(idTable);
        }

        public bool UpdateBill(int idBill, int statusBill, int idTable)
        {
            return BillDAL.Instance.UpdateBill(idBill, statusBill, idTable);
        }

        public bool DeleteBill(int idBill)
        {
            return BillDAL.Instance.DeleteBill(idBill);
        }

        public Bill GetOneBillById(int id)
        {
            return BillDAL.Instance.GetOneBillById(id);
        }
    }
}
