using XmiCore;


namespace XmiBuilder
{
    public class XmiSchemaBuilder
    {
        private readonly EntityManager<XmiBaseEntity> _entityManager = new();
        private readonly RelationshipManager<XmiBaseRelationship> _relationshipManager = new();

        public void AddEntity(XmiBaseEntity entity)
        {
            _entityManager.AddEntity(entity);
        }

        public void AddEntities(IEnumerable<XmiBaseEntity> entities)
        {
            foreach (var entity in entities)
                _entityManager.AddEntity(entity);
        }

        /// <summary>
        /// 构建 XmiModel，包括自动推理关系
        /// </summary>
        public XmiModel BuildModel()
        {
            var model = new XmiModel
            {
                Entities = _entityManager.GetAllEntities().ToList()
            };

            // 构建关系
            var exporter = new XmiRelationshipExporterExtension(_relationshipManager);
            exporter.ExportRelationships(model);

            model.Relationships = _relationshipManager.GetAll().ToList();
            return model;
        }

        /// <summary>
        /// 返回拓扑排序后的实体列表（可选）
        /// </summary>
        public List<XmiBaseEntity> GetTopologicallySortedEntities()
        {
            var model = BuildModel();
            var analyzer = new DependencyAnalyzerExtension(model.Entities, model.Relationships);
            return analyzer.GetTopologicallySortedEntities();
        }

        /// <summary>
        /// 检测循环依赖（可选）
        /// </summary>
        public List<List<XmiBaseEntity>> GetCycles()
        {
            var model = BuildModel();
            var analyzer = new DependencyAnalyzerExtension(model.Entities, model.Relationships);
            return analyzer.DetectCycles();
        }

        /// <summary>
        /// 直接导出为 JSON 文件
        /// </summary>
        public void ExportJson(string outputPath)
        {
            var model = BuildModel();
            var jsonBuilder = new XmiModelNativeJsonBuilderExtension(model);
            jsonBuilder.Save(outputPath);
        }

        /// <summary>
        /// 获取 JSON 字符串（不写入磁盘）
        /// </summary>
        public string BuildJsonString()
        {
            var model = BuildModel();
            var jsonBuilder = new XmiModelNativeJsonBuilderExtension(model);
            return jsonBuilder.BuildJson();
        }
    }
}
