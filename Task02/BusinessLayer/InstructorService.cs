using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class InstructorService
    {
        public static DataTable GetAll()
        {
            return DbContext.Select("select Ins_id, Ins_name, Ins_degree, Salary, Dept_Id from instructor");
        }
        public static int Insert(Instructor ins)
        {
            return DbContext.ExecuteNonQuery($"insert into instructor (Ins_name, Ins_degree, Salary, Dept_Id) values('{ins.Ins_name}','{ins.Ins_degree}',{ins.Salary},{ins.Dept_Id})");
        }
        public static int Update(Instructor ins)
        {
            return DbContext.ExecuteNonQuery($"update Instructor set Ins_Name = '{ins.Ins_name}', Ins_Degree = '{ins.Ins_degree}', Salary = {ins.Salary}, Dept_Id = {ins.Dept_Id} where Ins_Id = {ins.Ins_id}");
        }
        public static int Delete(int id)
        {
            return DbContext.ExecuteNonQuery($"delete from Instructor where Ins_Id = {id}");
        }
    }
}
