namespace XmiCore;

public class XmiHasPoint3D : XmiBaseRelationship
{
    public XmiHasPoint3D(
        string id,
        XmiBaseEntity source,
        XmiBaseEntity target,
        string name,
        string description,
        string entityName,
        string umlType
    ) : base(id, source, target, name, description, nameof(XmiHasPoint3D), "Association")
    {
    }

    public XmiHasPoint3D(
        XmiBaseEntity source,
        XmiBaseEntity target
    ) : base(source, target, nameof(XmiHasPoint3D), "Association")
    {
    }
}
