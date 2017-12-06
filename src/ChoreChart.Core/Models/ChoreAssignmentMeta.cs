namespace ChoreChart.Core.Models {
    public class ChoreAssignmentMeta {
        public long Id { get; set; }
        public long ChoreAssignmentId { get; set; }
        public virtual ChoreAssignment ChoreAssignment { get; set; }
        public ChoreAssignmentMetaType Type { get; set; }
        public string Value { get; set; }
    }
}