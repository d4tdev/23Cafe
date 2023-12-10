using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Response
    {
        public String message { get; set; }
        public bool error { get; set; }

        public Response() { }
        public Response(String message, bool err)
        {
            this.message = message;
            this.error = err;
        }
    }
}
