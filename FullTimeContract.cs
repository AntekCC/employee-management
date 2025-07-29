using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_system
{
    public class FullTimeContract : Contract
    {
        public string Ctype { get; set; }
        public int FulltimeMoney { get; set; }
        public int baseSalary { get; set; } = 5000;
        public int overtime { get; set; }
        Random rand = new Random();

      
        public FullTimeContract()
        {

            overtime = rand.Next(0, 21);
            FulltimeMoney = baseSalary + overtime * (baseSalary / 60);
            Ctype = $"Typ kontraktu: Pelen etat";

        }

        public  string ContractType()
        {
            return Ctype;

        }
        public  int Salary()
        {
            return FulltimeMoney;
        }


    }
}
