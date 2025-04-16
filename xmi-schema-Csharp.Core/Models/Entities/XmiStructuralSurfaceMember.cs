namespace XmiCore;

public class XmiStructuralSurfaceMember : XmiBaseEntity
{
    public XmiStructuralMaterial Material { get; set; }
    public XmiStructuralSurfaceMemberTypeEnum SurfaceMemberType { get; set; }
    public float Thickness { get; set; }
    public XmiStructuralSurfaceMemberSystemPlaneEnum SystemPlane { get; set; }
    public List<XmiStructuralPointConnection> Nodes { get; set; }
    public XmiStructuralStorey Storey { get; set; }

    public List<XmiSegment> Segments { get; set; }
    public float Area { get; set; }
    public float ZOffset { get; set; }
    public string LocalAxisX { get; set; }
    public string LocalAxisY { get; set; }
    public string LocalAxisZ { get; set; }
    public float Height { get; set; }
    public XmiStructuralSurfaceMember(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        XmiStructuralMaterial material,
        XmiStructuralSurfaceMemberTypeEnum surfaceMemberType,
        float thickness,
        XmiStructuralSurfaceMemberSystemPlaneEnum systemPlane,

        List<XmiStructuralPointConnection> nodes,
        XmiStructuralStorey storey,
        List<XmiSegment> segments,
        float area,
        float zOffset,
        string localAxisX,
        string localAxisY,
        string localAxisZ,
        float height

    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralSurfaceMember))
    {

        Material = material;
        SurfaceMemberType = surfaceMemberType;
        Thickness = thickness;
        SystemPlane = systemPlane;
        Nodes = nodes;
        Storey = storey;
        Segments= segments;
        Area = area;
        ZOffset = zOffset;
        LocalAxisX = localAxisX;
        LocalAxisY = localAxisY;
        LocalAxisZ = localAxisZ;
        Height = height;
    }
}
