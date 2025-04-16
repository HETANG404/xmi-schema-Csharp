namespace XmiCore;

public class XmiHasSegment : XmiBaseRelationship
{
    public XmiHasSegment(
        string id,
        XmiBaseEntity source,
        XmiBaseEntity target,
        string name,
        string description,
        string entityName,
        string umlType
    ) : base(id, source, target, name, description, nameof(XmiHasSegment), "Association")
    {
    }

    public XmiHasSegment(
        XmiBaseEntity source,
        XmiBaseEntity target
    ) : base(source, target, nameof(XmiHasSegment), "Association")
    {
    }
}
