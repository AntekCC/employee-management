using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_system
{
    public class InternContract : Contract
    {
        public string Ctype { get; set; }
        public int InternMoney { get; set; }



        public InternContract()
        {
            Ctype = $"Typ kontraktu: Staz";
            InternMoney = 2000;
        }
        public override string ContractType()
        {
            MainCtype = Ctype;
            return MainCtype;
        }
        public override int Salary()
        {
            MainMoney = InternMoney;
            return MainMoney;
        }
    }
}


