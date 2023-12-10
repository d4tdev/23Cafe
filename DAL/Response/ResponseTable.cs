using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponseTable : Response
    {
        public List<Table> data {  get; set; }
        public ResponseTable() { }
    }
}
