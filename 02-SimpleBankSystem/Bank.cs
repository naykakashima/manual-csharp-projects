using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public Bank() 
        {
            Balance = 1000;
        }
    }
}
