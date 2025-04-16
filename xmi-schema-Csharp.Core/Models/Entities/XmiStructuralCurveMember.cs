namespace XmiCore;

public class XmiStructuralCurveMember : XmiBaseEntity
{
    public XmiStructuralCrossSection CrossSection { get; set; }
    public XmiStructuralStorey Storey { get; set; }
    public XmiStructuralCurveMemberTypeEnum CurvememberType { get; set; }
    public List<XmiStructuralPointConnection> Nodes { get; set; }
    public List<XmiBaseEntity> Segments { get; set; }

    public XmiStructuralCurveMemberSystemLineEnum SystemLine { get; set; }
    public XmiStructuralPointConnection BeginNode { get; set; }
    public XmiStructuralPointConnection EndNode { get; set; }
    public float Length { get; set; }


    public string LocalAxisX { get; set; }
    public string LocalAxisY { get; set; }
    public string LocalAxisZ { get; set; }

    public float BeginNodeYOffset { get; set; }
    public float EndNodeYOffset { get; set; }
    public float BeginNodeZOffset { get; set; }
    public float EndNodeZOffset { get; set; }
    public float BeginNodeXOffset { get; set; }
    public float EndNodeXOffset { get; set; }


    public string EndFixityStart { get; set; }
    public string EndFixityEnd { get; set; }




    public XmiStructuralCurveMember(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        XmiStructuralCrossSection crossSection,
        XmiStructuralStorey storey,
        XmiStructuralCurveMemberTypeEnum curvememberType,
        List<XmiStructuralPointConnection> nodes,
        List<XmiBaseEntity> segments,
        XmiStructuralCurveMemberSystemLineEnum systemLine,
        XmiStructuralPointConnection beginNode,
        XmiStructuralPointConnection endNode,
        float length,

        string localAxisX,
        string localAxisY,
        string localAxisZ,
                float beginNodeXOffset,
        float endNodeXOffset,
        float beginNodeYOffset,
        float endNodeYOffset,
        float beginNodeZOffset,
        float endNodeZOffset,


        string endFixityStart,
        string endFixityEnd

    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralCurveMember))
    {
        CrossSection = crossSection;
        Storey = storey;
        CurvememberType = curvememberType;
        Nodes = nodes;
        Segments = segments;
        SystemLine = systemLine;
        BeginNode = beginNode;
        EndNode = endNode;
        Length = length;
        LocalAxisX = localAxisX;
        LocalAxisY = localAxisY;
        LocalAxisZ = localAxisZ;
        BeginNodeYOffset = beginNodeYOffset;
        EndNodeYOffset = endNodeYOffset;
        BeginNodeZOffset = beginNodeZOffset;
        EndNodeZOffset = endNodeZOffset;
        BeginNodeXOffset = beginNodeXOffset;
        EndNodeXOffset = endNodeXOffset;
        EndFixityStart = endFixityStart;
        EndFixityEnd = endFixityEnd;

    }
}
