namespace XmiCore;

public class XmiStructuralCrossSection : XmiBaseEntity
{
    public XmiStructuralMaterial Material { get; set; }     // Name of the material for element
    public XmiShapeEnum Shape { get; set; }                    // Shape of the cross section (Enum)
    public string[] Parameters { get; set; }               // Refer to "CrossSectionParameter temp ref" TAB
    public float Area { get; set; }                      // Cross-sectional area
    public float SecondMomentOfAreaXAxis { get; set; }                        // Second moment of area about x axis
    public float SecondMomentOfAreaYAxis { get; set; }                        // Second moment of area about y axis
    public float RadiusOfGyrationXAxis { get; set; }                        // Radius of gyration about x axis
    public float RadiusOfGyrationYAxis { get; set; }                        // Radius of gyration about y axis
    public float ElasticModulusXAxis { get; set; }                        // Elastic modulus about x axis
    public float ElasticModulusYAxis { get; set; }                        // Elastic modulus about y axis
    public float PlasticModulusXAxis { get; set; }                        // Plastic modulus about x axis
    public float PlasticModulusYAxis { get; set; }                        // Plastic modulus about y axis
    public float TorsionalConstant { get; set; }                         // Torsional constant

    public XmiStructuralCrossSection(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        XmiStructuralMaterial material,
        XmiShapeEnum shape,
        string[] parameters,
        float area,
        float secondMomentOfAreaXAxis,
        float secondMomentOfAreaYAxis,
        float radiusOfGyrationXAxis,
        float radiusOfGyrationYAxis,
        float elasticModulusXAxis,
        float elasticModulusYAxis,
        float plasticModulusXAxis,
        float plasticModulusYAxis,
        float torsionalConstant
    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralCrossSection))
    {
        Material = material;
        Shape = shape;
        Parameters = parameters;
        Area = area;
        SecondMomentOfAreaXAxis = secondMomentOfAreaXAxis;
        SecondMomentOfAreaYAxis = secondMomentOfAreaYAxis;
        RadiusOfGyrationXAxis = radiusOfGyrationXAxis;
        RadiusOfGyrationYAxis = radiusOfGyrationYAxis;
        ElasticModulusXAxis = elasticModulusXAxis;
        ElasticModulusYAxis = elasticModulusYAxis;
        PlasticModulusXAxis = plasticModulusXAxis;
        PlasticModulusYAxis = plasticModulusYAxis;
        TorsionalConstant = torsionalConstant;
    }
}
