using management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace management_system
{
    public class employeeBase
    {
        public string name { get; set; }
        public string surname { get; set; }
        public Contract contract { get; set; }
        public static List<employeeBase> AllEmployees = new List<employeeBase>();

        public Contract ChangeContract()
        {
            throw new NotImplementedException();

        }
        Contract contractType()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{name}{surname}{contract.Salary()}";
        }
    }


}


