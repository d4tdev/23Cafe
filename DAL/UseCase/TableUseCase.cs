using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UseCase
{
    public interface TableUseCase
    {
        List<Table> GetListTable();
        bool CheckTableExistsBill(int idTable);
        bool InsertTable(int idTable);
        bool DeleteTable(int idTable);
    }
}
