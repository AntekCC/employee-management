using management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementTest
{
    public class UserTest
    {
        [Fact]
        public void CheckUser()
        {
            EmployeeBase worker = new EmployeeBase("Jan", "Kowalski");
            worker.contract = new InternContract();
           var type =  worker.contract.ContractType();
            EmployeeBase.AllEmployees.Add(worker);
            Assert.Equal("Jan", worker.name);
            Assert.Equal("Kowalski", worker.surname);
            Assert.Equal("Typ kontraktu: Staz", type);
            Assert.Equal(1, EmployeeBase.AllEmployees.Count);
        }

    }
}
