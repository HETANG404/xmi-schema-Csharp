namespace XmiCore;

public class XmiBaseEntity
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string IFCGUID { get; set; }
    public string NativeId { get; set; }
    public string Description { get; set; }
    public string EntityType { get; set; }

    // 空构造函数

    // 带参数构造函数
    public XmiBaseEntity(
        string id,
        string name,
        string ifcguid,
        string nativeId ,
        string description,
        string entityType
    )
    {
        ID = id;
        Name = name;
        IFCGUID = ifcguid;
        NativeId = nativeId;
        Description = description;
        EntityType = string.IsNullOrEmpty(entityType) ? nameof(XmiBaseEntity) : entityType;
    }
}
