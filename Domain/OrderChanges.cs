using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class OrderChanges
    {
        public Order Order { get; set; }
        public int Id { get; set; }
    }
}
