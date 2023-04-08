using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    class Cerveza : Bebida
    {
        public Cerveza() : base("Cerveza", 200)
        {
        }
            public int Alcohol { get; set; }
            public string Marca { get; set; }
    }
}

