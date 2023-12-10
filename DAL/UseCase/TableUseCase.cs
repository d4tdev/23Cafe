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
        Object GetListTable();
        Object CheckTableExistsBill(int idTable);
        Object InsertTable();
        Object DeleteTable(int idTable);
    }
}
