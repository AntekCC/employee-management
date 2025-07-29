using management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace management_system
{
    public class EmployeeBase
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int overtime { get; set; }
        public Contract contract { get; set; }
        public static List<EmployeeBase> AllEmployees = new List<EmployeeBase>();


        public EmployeeBase(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.contract = new InternContract();

        }


        public void ChangeContract()
            
        {
            if (contract is InternContract)
            {
                contract = new FullTimeContract(overtime);
            }
            else
            {
                contract = new InternContract();
            }
            contract.ContractType();
            contract.Salary();
        }
        public int GetSalary()
        {
            if (contract is InternContract)
            {
                return contract.Salary();
            }
            else
            {
                return contract.Salary();
            }
        }
        public override string ToString()
        {
            return $"{name}{surname}{contract.Salary()}";
        }
    }


}


