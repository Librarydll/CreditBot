using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string GroupUniqueId { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<Member> Members { get; set; }
    }
}
