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
        Object GetAllListBill();
        Object InsertBill(int idTable);
        Object UpdateBill(int idBill, int statusBill, int idTable);
        Object DeleteBill(int idBill);
        Object GetOneBillById(int id);

    }
}
