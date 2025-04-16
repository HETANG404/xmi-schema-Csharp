namespace XmiCore
{
    public interface IRelationshipManager<T> where T : XmiBaseRelationship
    {
        /// <summary>
        /// 添加关系对象
        /// </summary>
        bool AddRelationship(T relationship);

        /// <summary>
        /// 移除指定 ID 的关系
        /// </summary>
        bool RemoveRelationship(string id);

        /// <summary>
        /// 获取指定 ID 的关系对象
        /// </summary>
        T? GetRelationship(string id);

        /// <summary>
        /// 获取所有关系对象
        /// </summary>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 根据 Source ID 查找关系对象
        /// </summary>
        IEnumerable<T> FindBySource(string sourceId);

        /// <summary>
        /// 根据 Target ID 查找关系对象
        /// </summary>
        IEnumerable<T> FindByTarget(string targetId);

        /// <summary>
        /// 清空所有关系
        /// </summary>
        void Clear();
    }
}
