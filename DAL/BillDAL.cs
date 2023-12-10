using DAL.UseCase;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL : OrderUseCase
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }

        public Object GetAllListBill()
        {
            ResponseBill res = new ResponseBill();
            try
            {
                List<Bill> list = new List<Bill>();

                string query = "SELECT id, date_checkout,id_table, status_bill, total_price FROM Bill";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Bill bill = new Bill(item);
                    list.Add(bill);
                }
                res.error = false;
                res.message = "";
                res.data = list;
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                res.data = null;
                return res;
            }
        }

        public Object InsertBill(int idTable)
        {
            Response res = new Response();
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { idTable });
                res.error = result > 0 ? false : true;
                res.message = "";
                return res;
            } catch (Exception e)
            {
                res.error = true;
                res.message = e.Message;
                return res;
            }
        }

        public Object UpdateBill(int idBill, int statusBill, int idTable)
        {
            Response res = new Response();
            try
            {
                string query = string.Format("UPDATE Bill SET status_bill = {1}, id_table = {2} WHERE id = {0}", idBill, statusBill, idTable);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                res.error = result > 0 ? false : true;
                res.message = "";
                return res;
            } catch (Exception e)
            {
                res.error = true;
                res.message = e.Message;
                return res;
            }
        }

        public Object DeleteBill(int idBill)
        {
            Response res = new Response();
            try
            {
                string query = string.Format("Delete from Bill WHERE id = {0}", idBill);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                res.error = result > 0 ? false : true;
                res.message = "";
                return res;
            } catch(Exception e)
            {
                res.error = true;
                res.message = e.Message;
                return res;
            }
        }

        public Object GetOneBillById(int id)
        {
            ResponseOneBill res = new ResponseOneBill();
            try
            {
                string query = string.Format("SELECT * FROM Bill WHERE id={0}", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data != null )
                {
                    foreach (DataRow item in data.Rows)
                    {
                        res.data = new Bill(item);
                        res.error = false;
                        res.message = "";
                        return res;

                    }
                }
                res.error= false;
                res.message = "Không có hóa đơn";
                res.data= null;
                return res;
            } catch (Exception ex)
            {
                res.error = true;
                res.message = ex.Message;
                return res;
            }
        }
    }
}
