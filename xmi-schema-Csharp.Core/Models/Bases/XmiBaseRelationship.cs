namespace XmiCore;

public class XmiBaseRelationship
{
    public string ID { get; set; }
    public XmiBaseEntity Source { get; set; }
    public XmiBaseEntity Target { get; set; }
    public string Name { get; set; }
     public string Description { get; set; }
    public string EntityType { get; set; }
    public string UmlType{get; set;}
    public XmiBaseRelationship(
        string id,
        XmiBaseEntity source,
        XmiBaseEntity target,
        string name,
        string description,
        string entityType,
        string umlTtype
    )
    {
        ID = id;
        Source = source;
        Target = target;
        Name = string.IsNullOrEmpty(name) ? "Unnamed"  : name;
        Description = string.IsNullOrEmpty(description) ? "" : description;
        EntityType = string.IsNullOrEmpty(entityType) ? nameof(XmiBaseRelationship) : entityType;
        UmlType = string.IsNullOrEmpty(umlTtype)? "": umlTtype;
    }
    public XmiBaseRelationship(XmiBaseEntity source, XmiBaseEntity target, string entityType, string umlType)
            : this(Guid.NewGuid().ToString(), source, target, entityType, "", entityType, umlType)
    {        
    }
}
