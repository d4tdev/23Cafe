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

        public List<Bill> GetAllListBill()
        {
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
                return list;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public bool InsertBill(int idTable)
        {
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { idTable });
                return result > 0;
            } catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateBill(int idBill, int statusBill, int idTable)
        {
            try
            {
                string query = string.Format("UPDATE Bill SET status_bill = {1}, id_table = {2} WHERE id = {0}", idBill, statusBill, idTable);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            } catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteBill(int idBill)
        {
            try
            {
                string query = string.Format("Delete from Bill WHERE id = {0}", idBill);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            } catch(Exception e)
            {
                return false;
            }
        }

        public Bill GetOneBillById(int id)
        {
            try
            {
                string query = string.Format("SELECT * FROM Bill WHERE id={0}", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    return new Bill(item);
                }
                return null;
            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
