using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponseOneBill : Response
    {
        public ResponseOneBill() { }
        public Bill data { get; set; }
    }
}
