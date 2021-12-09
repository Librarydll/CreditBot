using CreditBot.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Domain.Entities
{
    public class CreditHistory : BaseEntity
    {
        public int CreditCount { get; set; }
        public ActionType ActionType { get; set; }
        public DateTime Created { get; set; }
    }
}
