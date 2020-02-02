using SGO.Models.API;
using System;
using System.Collections.Generic;

namespace SGO.ViewModels.API
{
    public class EmployeeVM
    {
        public List<Employee> EmployeeDatabase()
        {
            List<Employee> lsData = new List<Employee> { 
                new Employee { Emp_ID = "E-01", Emp_name = "Arm", Emp_Dep = "IT",Emp_phone = "8711" },
                new Employee { Emp_ID = "E-02", Emp_name = "John", Emp_Dep = "IT" ,Emp_phone = "8314" },
                new Employee { Emp_ID = "E-03", Emp_name = "Ant",Emp_Dep = "HR" ,Emp_phone = "2711" },
                new Employee { Emp_ID = "E-04", Emp_name = "Job", Emp_Dep = "HR" ,Emp_phone = "8714" }
            };
            return lsData;
        }

    }
}
