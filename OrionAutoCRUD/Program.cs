using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionAutoCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            autocrudEntities ctx = new autocrudEntities();
            
            CRUDClass<Employee>.Initialize(ctx);  // First action

            /// Insert Sample
            /// 
            Employee emp = new Employee()
            {
                EmployeeName = "Kwami",
                IsDeleted = false
            };
            CRUDClass<Employee>.Insert(emp);

            /// GetAll Sample
            /// 

            var allEmployees = CRUDClass<Employee>.Get();


            /// Get the Employee with id = 1 sample
            /// 

            var employee = CRUDClass<Employee>.Get(1);

            /// Update the employee with id = 1
            /// 
            employee.IsDeleted = true;

            CRUDClass<Employee>.Update(employee.Id, employee);


            /// Delete the employee with id 1
            /// 

            CRUDClass<Employee>.Delete(1);

        }
    }
}
