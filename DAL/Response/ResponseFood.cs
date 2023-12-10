using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResponseFood : Response
    {
        public List<Food> data {  get; set; }
        public ResponseFood(Response res, List<Food> data) : base(res.message, res.error)
        {
            this.data = data;
        }

        public ResponseFood() { }
    }
}
