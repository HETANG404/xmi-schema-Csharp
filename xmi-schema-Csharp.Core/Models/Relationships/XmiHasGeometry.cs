namespace XmiCore;

public class XmiHasGeometry : XmiBaseRelationship
{
    public XmiHasGeometry(
        string id,
        XmiBaseEntity source,
        XmiBaseGeometry target,
        string name,
        string description,
        string entityName,
        string umlType
    ) : base(id, source, target, name, description, nameof(XmiHasGeometry), "Association")
    {
    }

    public XmiHasGeometry(
        XmiBaseEntity source,
        XmiBaseGeometry target
    ) : base(source, target, nameof(XmiHasGeometry), "Association")
    {
    }
}
