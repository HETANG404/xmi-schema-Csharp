using QuikGraph;
using QuikGraph.Algorithms.TopologicalSort;

namespace XmiCore;


// DependencyAnalyzer
public class DependencyAnalyzerExtension
{
    private readonly AdjacencyGraph<XmiBaseEntity, Edge<XmiBaseEntity>> _graph;

    public DependencyAnalyzerExtension(List<XmiBaseEntity> entities, List<XmiBaseRelationship> relationships)
    {
        _graph = new AdjacencyGraph<XmiBaseEntity, Edge<XmiBaseEntity>>();

        foreach (var e in entities)
            _graph.AddVertex(e);

        foreach (var r in relationships)
        {
            if (r.Source != null && r.Target != null)
                _graph.AddEdge(new Edge<XmiBaseEntity>(r.Source, r.Target));
        }
    }

    public List<XmiBaseEntity> GetTopologicallySortedEntities()
    {
        try
        {
            var sorter = new TopologicalSortAlgorithm<XmiBaseEntity, Edge<XmiBaseEntity>>(_graph);
            sorter.Compute();
            return sorter.SortedVertices.ToList();
        }
        catch
        {
            Console.WriteLine("Topological sorting fails (circular dependencies may exist), returning to the original order");
            return _graph.Vertices.ToList();
        }
    }

    public List<List<XmiBaseEntity>> DetectCycles()
    {
        var cycles = new List<List<XmiBaseEntity>>();
        var visited = new HashSet<XmiBaseEntity>();
        var stack = new Stack<XmiBaseEntity>();

        void Visit(XmiBaseEntity node)
        {
            if (stack.Contains(node))
            {
                cycles.Add(stack.Reverse().SkipWhile(n => !n.Equals(node)).Append(node).ToList());
                return;
            }

            if (!visited.Add(node))
                return;

            stack.Push(node);
            foreach (var edge in _graph.OutEdges(node))
                Visit(edge.Target);
            stack.Pop();
        }

        foreach (var node in _graph.Vertices)
            Visit(node);

        return cycles;
    }
}
