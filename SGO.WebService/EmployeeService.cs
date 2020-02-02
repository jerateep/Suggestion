using SGO.Models.API;
using SGO.ViewModels.API;
using System;
using System.Linq;

namespace SGO.WebService
{
    public class EmployeeService
    {
        public static Employee GetEmployee(string Employee_id)
        {
            EmployeeVM Db = new EmployeeVM();
            var EmpAll = Db.EmployeeDatabase();
            Employee emp = EmpAll.Where(k => k.Emp_ID == Employee_id).FirstOrDefault();
            return emp;
        }
    }
}
