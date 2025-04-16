
using XmiCore;

public class RelationshipManager<T> : IRelationshipManager<T>where T : XmiBaseRelationship
{
    private readonly Dictionary<string, T> _relationships = new();

    public bool AddRelationship(T relationship)
    {
        if (relationship == null || string.IsNullOrWhiteSpace(relationship.ID))
            return false;

        _relationships[relationship.ID] = relationship;
        return true;
    }

    public bool RemoveRelationship(string id)
    {
        return _relationships.Remove(id);
    }

    public T? GetRelationship(string id)
    {
        return _relationships.TryGetValue(id, out var rel) ? rel : null;
    }

    public IEnumerable<T> GetAll()
    {
        return _relationships.Values;
    }

    public IEnumerable<T> FindBySource(string sourceId)
    {
        return _relationships.Values.Where(r => r.Source.ID == sourceId);
    }

    public IEnumerable<T> FindByTarget(string targetId)
    {
        return _relationships.Values.Where(r => r.Target.ID == targetId);
    }

    public void Clear()
    {
        _relationships.Clear();
    }
}
