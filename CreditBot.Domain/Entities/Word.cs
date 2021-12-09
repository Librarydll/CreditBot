using CreditBot.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Domain.Entities
{
    public class Word : BaseEntity
    {
        public int? DeletedByMemberId { get; set; }
        public Member DeletedByMember { get; set; }
        public int CreatedByMemberId { get; set; }
        public Member CreatedByMember { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public ActionType ActionType { get; set; }
    }
}
