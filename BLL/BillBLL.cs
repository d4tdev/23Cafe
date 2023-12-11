using DAL;
using DAL.UseCase;
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
            ResponseBill res = (ResponseBill) BillDAL.Instance.GetAllListBill();
            if (res.error == false) return res.data;
            else return null;
        }

        public bool InsertBill(int idTable)
        {
            if (string.IsNullOrEmpty(idTable.ToString()) || string.IsNullOrWhiteSpace(idTable.ToString()))
            {
                return false;
            }
            Response res = (Response)BillDAL.Instance.InsertBill(idTable);
            if (res.error == false) return true;
            else return false;
        }

        public bool UpdateBill(int idBill, int statusBill, int idTable)
        {
            if (string.IsNullOrEmpty(idTable.ToString()) || string.IsNullOrWhiteSpace(idTable.ToString())
                || string.IsNullOrEmpty(statusBill.ToString()) || string.IsNullOrWhiteSpace(statusBill.ToString())
                || string.IsNullOrEmpty(idTable.ToString()) || string.IsNullOrWhiteSpace(idTable.ToString()))
            {
                return false;
            }
            Response res = (Response)BillDAL.Instance.UpdateBill(idBill, statusBill, idTable);
            if (res.error == false) return true;
            else return false;
        }

        public bool DeleteBill(int idBill)
        {
            if (string.IsNullOrEmpty(idBill.ToString()) || string.IsNullOrWhiteSpace(idBill.ToString()))
            {
                return false;
            }
            Response res= (Response) BillDAL.Instance.DeleteBill(idBill);
            if (res.error == false) return true;
            else return false;
        }

        public Bill GetOneBillById(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()) || string.IsNullOrWhiteSpace(id.ToString()))
            {
                return null;
            }
            ResponseOneBill res = (ResponseOneBill) BillDAL.Instance.GetOneBillById(id);
            if (res.error == false) return res.data;
            else return null;
        }
    }
}
