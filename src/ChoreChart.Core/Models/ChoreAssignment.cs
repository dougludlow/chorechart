using System.Collections.Generic;

namespace ChoreChart.Core.Models
{
    public class ChoreAssignment
    {
        public long Id { get; set; }
        public long ChoreId { get; set; }
        public long FamilyMemberId { get; set; }
        public virtual Chore Chore { get; set; }
        public virtual FamilyMember FamilyMember { get; set; }
        public ICollection<ChoreAssignmentMeta> Meta { get; set; } = new HashSet<ChoreAssignmentMeta>();
        
    }
}