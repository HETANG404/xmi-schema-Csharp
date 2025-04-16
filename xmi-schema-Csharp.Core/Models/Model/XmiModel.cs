namespace XmiCore
{
    public class XmiModel
    {
        public List<XmiBaseEntity> Entities { get; set; } = new();
        public List<XmiBaseRelationship> Relationships { get; set; } = new();
    }
}
