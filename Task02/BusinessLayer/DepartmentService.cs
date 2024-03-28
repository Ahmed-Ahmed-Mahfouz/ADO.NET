using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class DepartmentService
    {
        public static DataTable GetAll()
        {
            return DbContext.Select("select Dept_id, Dept_name from Department");
        }
    }
}
