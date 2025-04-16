namespace XmiCore;


public class EntityManager<T> : IEntityManager<T> where T : XmiBaseEntity
{
    private readonly Dictionary<string, T> _entities = new();

    public bool AddEntity(T entity)
    {
        if (string.IsNullOrWhiteSpace(entity.ID)) return false;

        _entities[entity.ID] = entity;
        return true;
    }

    public bool RemoveEntity(string id)
    {
        return _entities.Remove(id);
    }

    public T? GetEntity(string id)
    {
        return _entities.TryGetValue(id, out var entity) ? entity : null;
    }

    public IEnumerable<T> GetAllEntities()
    {
        return _entities.Values;
    }

    public IEnumerable<T> FindByName(string name)
    {
        return _entities.Values.Where(e => e.Name == name);
    }

    public void Clear()
    {
        _entities.Clear();
    }
}
