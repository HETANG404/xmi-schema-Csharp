namespace XmiCore;

public class XmiLine3D : XmiBaseGeometry
{
    public XmiPoint3D StartPoint3D { get; set; }
    public XmiPoint3D EndPoint3D { get; set; }

    public XmiLine3D(
        string id,
        string name,
        string ifcGuid,
        string nativeId,
        string description,
        XmiPoint3D startPoint3D,
        XmiPoint3D endPoint3D
    ) : base(id, name, ifcGuid, nativeId, description)
    {
        StartPoint3D = startPoint3D;
        EndPoint3D = endPoint3D;
        EntityType = nameof(XmiLine3D);
    }
}
