using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillInfoBLL
    {
        private static BillInfoBLL instance;
        public static BillInfoBLL Instance
        {
            get { if (instance == null) instance = new BillInfoBLL(); return BillInfoBLL.instance; }
            private set { BillInfoBLL.instance = value; }
        }
        public BillInfoBLL() { }
        public List<BillInfo> GetAllListBillInfo()
        {
            return BillInfoDAL.Instance.GetAllListBillInfo();
        }

        public bool InsetAndUpdateBillInfo(int id_bill, string id_food, int quantity)
        {
            if (string.IsNullOrEmpty(id_bill.ToString()) || string.IsNullOrWhiteSpace(id_bill.ToString())
                || string.IsNullOrEmpty(quantity.ToString()) || string.IsNullOrWhiteSpace(quantity.ToString())
                || string.IsNullOrEmpty(id_food.ToString()) || string.IsNullOrWhiteSpace(id_food.ToString()))
            {
                return false;
            }
            return BillInfoDAL.Instance.InsertAndUpdateBillInfo(id_bill, id_food, quantity);
        }

        public bool UpdateBillInfo(int id_bill, string id_food, int quantity, int id)
        {
            if (string.IsNullOrEmpty(id_bill.ToString()) || string.IsNullOrWhiteSpace(id_bill.ToString())
                || string.IsNullOrEmpty(quantity.ToString()) || string.IsNullOrWhiteSpace(quantity.ToString())
                || string.IsNullOrEmpty(id_food) || string.IsNullOrWhiteSpace(id_food)
                || string.IsNullOrEmpty(id.ToString()) || string.IsNullOrWhiteSpace(id.ToString()))
            {
                return false;
            }
            return BillInfoDAL.Instance.UpdateBillInfo(id_bill, id_food, quantity, id);
        }

        public bool DeleteBillInfo(string foodId)
        {
            if (string.IsNullOrEmpty(foodId) || string.IsNullOrWhiteSpace(foodId))
            {
                return false;
            }
            return BillInfoDAL.Instance.DeleteBillInfo(foodId);
        }

        public List<BillInfo> GetListByIdBill(int idBill)
        {
            if (string.IsNullOrEmpty(idBill.ToString()) || string.IsNullOrWhiteSpace(idBill.ToString()))
            {
                return null;
            }
            return BillInfoDAL.Instance.GetListByIdBill(idBill);
        }
    }
}
