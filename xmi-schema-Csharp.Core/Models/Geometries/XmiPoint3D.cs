namespace XmiCore;

public class XmiPoint3D : XmiBaseGeometry
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public XmiPoint3D(
        string id,
        string name,
        string ifcGuid,
        string nativeId,
        string description,
        float x,
        float y,
        float z
    ) : base(id, name, ifcGuid, nativeId, description)
    {
        X = x;
        Y = y;
        Z = z;
        EntityType = nameof(XmiPoint3D);
    }
}
