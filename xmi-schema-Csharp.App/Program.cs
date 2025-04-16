
using System;
using System.Collections.Generic;
using XmiCore;
using XmiBuilder;

class Program
{
    static void Main(string[] args)
    {
        var builder = new XmiSchemaBuilder();

        // 创建基础数据
        var point1 = new XmiPoint3D("p1", "Point1", "", "", "", 0, 0, 0);
        var point2 = new XmiPoint3D("p2", "Point2", "", "", "", 5, 0, 0);

        var storey = new XmiStructuralStorey("s1", "Storey1", "", "", "", 3.5f, 5000, "RX", "RY", "RZ");

        var node1 = new XmiStructuralPointConnection("n1", "Node1", "", "", "", storey, point1);
        var node2 = new XmiStructuralPointConnection("n2", "Node2", "", "", "", storey, point2);

        var material = new XmiStructuralMaterial("m1", "Concrete", "", "", "", XmiStructuralMaterialTypeEnum.Concrete, 30, 25, 30000, 12000, 0.2f, 1.2e-5f);

        var crossSection = new XmiStructuralCrossSection(
            "cs1", "RectSection", "", "", "", material, XmiShapeEnum.Rectangular,
            new[] { "b=300", "h=500" }, 150000, 6250000, 6250000, 144.3f, 144.3f,
            200000, 200000, 250000, 250000, 12000000);

        var segment = new XmiSegment("seg1", "Segment1", "", "", "", null, 0f, node1, node2, XmiSegmentTypeEnum.Line);

        var curve = new XmiStructuralCurveMember(
            "cm1", "Beam1", "", "", "", crossSection, storey,
            XmiStructuralCurveMemberTypeEnum.Beam,
            new List<XmiStructuralPointConnection> { node1, node2 },
            new List<XmiBaseEntity> { segment },
            XmiStructuralCurveMemberSystemLineEnum.MiddleMiddle,
            node1, node2,
            5.0f,
            "1,0,0", "0,1,0", "0,0,1",
            0, 0, 0, 0, 0, 0,
            "Fixed", "Pinned"
        );

        // 注册到 builder
        builder.AddEntities(new List<XmiBaseEntity>
        {
            point1, point2, node1, node2, material, crossSection, segment, curve, storey
        });

        // 构建并导出 JSON
        builder.ExportJson("XmiModel_Output.json");

        Console.WriteLine("✅ 模型构建并导出成功！");
    }
}
