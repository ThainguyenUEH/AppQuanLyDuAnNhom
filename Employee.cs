using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public Employee(string employeeId, string name, string email, string gender, int age)
        {
            EmployeeId = employeeId;
            Name = name;
            Email = email;
            Gender = gender;
            Age = age;
        }
    }
}
