using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UseCase
{
    public interface OrderUseCase
    {
        List<Bill> GetAllListBill();
        bool InsertBill(int idTable);
        bool UpdateBill(int idBill, int statusBill, int idTable);
        bool DeleteBill(int idBill);
        Bill GetOneBillById(int id);

    }
}
