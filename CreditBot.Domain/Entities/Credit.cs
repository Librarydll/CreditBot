using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Domain.Entities
{
    public class Credit : BaseEntity
    {
        public int CreditCount { get; set; }
        public DateTime Created { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
