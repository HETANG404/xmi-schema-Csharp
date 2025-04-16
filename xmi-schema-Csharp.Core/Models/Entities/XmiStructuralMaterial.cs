namespace XmiCore;

public class XmiStructuralMaterial : XmiBaseEntity
{
    public XmiStructuralMaterialTypeEnum MaterialType { get; set; }                  // Type of material (Enum)
    public float Grade { get; set; }                  // Material grade (fck, fy, yield strength, etc.)
    public float UnitWeight { get; set; }             // Unit weight of the material
    public float EModulus { get; set; }               // Young's modulus
    public float GModulus { get; set; }               // Shear modulus
    public float PoissonRatio { get; set; }           // Poisson ratio
    public float ThermalCoefficient { get; set; }     // Thermal expansion coefficient

    public XmiStructuralMaterial(
        string id,
        string name,
        string ifcguid,
        string nativeId,
        string description,
        XmiStructuralMaterialTypeEnum materialType,
        float grade,
        float unitWeight,
        float eModulus,
        float gModulus,
        float poissonRatio,
        float thermalCoefficient
    ) : base(id, name, ifcguid, nativeId, description, nameof(XmiStructuralMaterial))
    {
        MaterialType = materialType;
        Grade = grade;
        UnitWeight = unitWeight;
        EModulus = eModulus;
        GModulus = gModulus;
        PoissonRatio = poissonRatio;
        ThermalCoefficient = thermalCoefficient;
    }
}
