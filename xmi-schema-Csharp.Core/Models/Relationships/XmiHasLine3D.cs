namespace XmiCore;

public class XmiHasLine3D : XmiBaseRelationship
{
    public XmiHasLine3D(
        string id,
        XmiBaseEntity source,
        XmiBaseEntity target,
        string name,
        string description,
        string entityName,
        string umlType
    ) : base(id, source, target, name, description, nameof(XmiHasLine3D), "Association")
    {
    }

    public XmiHasLine3D(
        XmiBaseEntity source,
        XmiBaseEntity target
    ) : base(source, target, nameof(XmiHasLine3D), "Association")
    {
    }
}
