using System.Collections.Generic;

namespace XmiCore
{
    public interface IModelManager
    {
        void AddEntity(XmiBaseEntity entity);

        void CreateRelationship(XmiBaseRelationship relationship);

        List<XmiBaseEntity> GetAllEntities();

        List<XmiBaseRelationship> GetAllRelationships();
    }
}
