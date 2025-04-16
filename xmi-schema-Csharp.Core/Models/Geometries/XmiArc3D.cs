namespace XmiCore;

public class XmiArc3D : XmiBaseGeometry
{
    public XmiPoint3D StartPoint { get; set; }
    public XmiPoint3D EndPoint { get; set; }
    public XmiPoint3D CentrePoint { get; set; }
    public float Radius { get; set; }

    public XmiArc3D(
        string id,
        string name,
        string ifcGuid,
        string nativeId,
        string description,
        XmiPoint3D startPoint ,
        XmiPoint3D endPoint ,
        XmiPoint3D centrePoint ,
        float radius
    ) : base(id, name, ifcGuid, nativeId, description)
    {
        StartPoint  = startPoint ;
        EndPoint  = endPoint ;
        CentrePoint  = centrePoint ;
        Radius = radius;
        EntityType = nameof(XmiArc3D);
    }
}
