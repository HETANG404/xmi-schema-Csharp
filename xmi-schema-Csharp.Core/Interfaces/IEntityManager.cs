namespace XmiCore
{
    public interface IEntityManager<T> where T : XmiBaseEntity
    {
        /// <summary>
        /// 添加节点对象
        /// </summary>
        bool AddEntity(T Entity);

        /// <summary>
        /// 移除指定 ID 的节点
        /// </summary>
        bool RemoveEntity(string id);

        /// <summary>
        /// 获取指定 ID 的节点对象
        /// </summary>
        T? GetEntity(string id);

        /// <summary>
        /// 获取所有节点对象
        /// </summary>
        IEnumerable<T> GetAllEntities();

        /// <summary>
        /// 根据 Source ID 查找节点对象
        /// </summary>
        IEnumerable<T> FindByName(string name);

        /// <summary>


        /// <summary>
        /// 清空所有节点
        /// </summary>
        void Clear();
    }
}
