using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;



namespace management_system
{
    public interface Contract
    {
        public string ContractType();
        public int Salary();
    }
}

