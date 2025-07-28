using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace management_system
{
    public abstract class Contract
    {
        public int MainMoney { get; set; }
        public string MainCtype { get; set; }
        public abstract string ContractType();
        public abstract int Salary();
    }
}

