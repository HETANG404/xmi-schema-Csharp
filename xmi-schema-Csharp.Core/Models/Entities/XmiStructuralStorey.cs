namespace XmiCore;

public class XmiStructuralStorey : XmiBaseEntity
{
    public float StoreyElevation { get; set; }
    public float StoreyMass { get; set; }
    public string StoreyHorizontalReactionX { get; set; }
    public string StoreyHorizontalReactionY { get; set; }
    public string StoreyVerticalReaction { get; set; }

    public XmiStructuralStorey(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        float storeyElevation,
        float storeyMass,
        string storeyHorizontalReactionX,
        string storeyHorizontalReactionY,
        string storeyVerticalReaction
    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralStorey))
    {
        StoreyElevation = storeyElevation;
        StoreyMass = storeyMass;
        StoreyHorizontalReactionX = storeyHorizontalReactionX;
        StoreyHorizontalReactionY = storeyHorizontalReactionY;
        StoreyVerticalReaction = storeyVerticalReaction;
    }
}
