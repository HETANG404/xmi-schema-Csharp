namespace XmiCore;

public class XmiStructuralUnit : XmiBaseEntity
{
    public string Entity { get; set; }
    public string Attribute { get; set; }
    public XmiUnitEnum Unit { get; set; }

    public XmiStructuralUnit(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        string entity,
        string attribute,
        XmiUnitEnum unit
    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralUnit))
    {
        Entity = entity;
        Attribute = attribute;
        Unit = unit;
    }
}
