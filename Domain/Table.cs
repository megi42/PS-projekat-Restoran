using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Table
    {
        public int TableNumber { get; set; }
        public override string ToString()
        {
            return $"{TableNumber}";
        }
    }
}
