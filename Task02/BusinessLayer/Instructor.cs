using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Instructor
    {
        public int Ins_id { get; set; }
        public string Ins_name { get; set; }
        public string Ins_degree { get; set; }
        public decimal Salary { get; set; }
        public int Dept_Id { get; set; }
    }
}
