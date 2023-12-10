using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponseBill : Response
    {
        public List<Bill> data {  get; set; }
        public ResponseBill() { }
    }
}
