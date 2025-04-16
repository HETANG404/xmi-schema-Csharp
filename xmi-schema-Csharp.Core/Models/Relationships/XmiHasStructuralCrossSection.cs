namespace XmiCore;

public class XmiHasStructuralCrossSection : XmiBaseRelationship
{
    public XmiHasStructuralCrossSection(
        string id,
        XmiBaseEntity source,
        XmiBaseEntity target,
        string name,
        string description,
        string entityName,
        string umlType
    ) : base(id, source, target, name, description, nameof(XmiHasStructuralCrossSection), "Association")
    {
    }

    public XmiHasStructuralCrossSection(
        XmiBaseEntity source,
        XmiBaseEntity target
    ) : base(source, target, nameof(XmiHasStructuralCrossSection), "Association")
    {
    }
}
