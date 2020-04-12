using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Data.Models;

namespace EPM.Data
{
    public class EmployeeService
    {
        public EmployeeService(){

        }

        public List<Employees> getEmployees(){
            var context =  new EPMDBContext();
            return context.Employees.ToList();
        }
    }
}
