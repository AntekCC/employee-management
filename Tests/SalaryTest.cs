using management_system;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ManagementTest
{
    public class SalaryTest
    {
        [Fact]
        public void CheckInternSalary()
        {

            Contract contract = new InternContract();
            var salary = contract.Salary();
            var type = contract.ContractType();
            Assert.Equal(2000, salary);
            Assert.Equal("Typ kontraktu: Staz", type);
        }
        [Fact]
        public void CheckFullTimeSalary()
        {
            int overtime = 10;
            Contract contract = new FullTimeContract(overtime);
            var salary = contract.Salary();
            var type = contract.ContractType();

            Assert.Equal(5000 + overtime * (5000 / 60), salary);
            Assert.Equal("Typ kontraktu: Pelen etat", type);
        }

    }
}
