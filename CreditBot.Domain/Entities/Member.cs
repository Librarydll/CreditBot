using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBot.Domain.Entities
{
    public class Member : BaseEntity
    {
        public string MemberUniqueId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Word> CreatedWords { get; set; }
        public ICollection<Word> DeletedWords { get; set; }
    }
}
