namespace XmiCore;
using Newtonsoft.Json;
public class XmiModelNativeJsonBuilderExtension
{
    private readonly XmiModel _model;

    public XmiModelNativeJsonBuilderExtension(XmiModel model)
    {
        _model = model;
    }

    public string BuildJson()
    {
        var nodes = _model.Entities.Select(e => new
        {
            id = e.ID,
            label = e.Name,
            type = e.EntityType,
            attributes = GetAttributes(e)
        }).ToList();

        var edges = _model.Relationships.Select(r => new
        {
            id = r.ID,
            label = r.EntityType,
            source = r.Source?.ID,
            target = r.Target?.ID,
            attributes = GetAttributes(r)
        }).ToList();

        var graphJson = new
        {
            nodes,
            edges
        };

        return JsonConvert.SerializeObject(graphJson, Formatting.Indented);
    }

    public void Save(string path)
    {
        File.WriteAllText(path, BuildJson());
        Console.WriteLine($"JSON 图文件保存成功：{path}");
    }

    private Dictionary<string, object> GetAttributes(object obj)
    {
        var dict = new Dictionary<string, object>();

        var props = obj.GetType().GetProperties();

        foreach (var prop in props)
        {
            // 避免递归引用或复杂对象（如 Source、Target）
            if (typeof(XmiBaseEntity).IsAssignableFrom(prop.PropertyType) || prop.PropertyType.Namespace?.StartsWith("System") != true)
                continue;

            var value = prop.GetValue(obj);
            if (value != null)
                dict[prop.Name] = value;
        }

        return dict;
    }
}
