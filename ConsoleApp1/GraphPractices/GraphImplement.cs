using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.GraphPractices
{
    public class MyGraph
    {
        public int NumberOfNodes;
        public Dictionary<int,List<int>> AdjacentList;
        public MyGraph()
        {
            NumberOfNodes = 0;
            AdjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int node)
        {
            //如果已經有節點 54ㄊ
            if(AdjacentList.TryGetValue(node,out _))
            {
                return;
            }
            AdjacentList.Add(node, new List<int>());
            NumberOfNodes++;
        }
        public void AddEdge(int node1,int node2)
        {
            if (!AdjacentList.TryGetValue(node1, out _) || !AdjacentList.TryGetValue(node2, out _))
            {
                //這邊 報錯
                return;
            }

            //node1 = 1 , node2 = 0
            // 1 => index 0 +1
            AdjacentList[node1].Add(node2);
            // 0 => index 1 +1
            AdjacentList[node2].Add(node1);
        }

        public void ShowConnections()
        {
            foreach (var item in AdjacentList)
            {
                List<int> nodeConnections = AdjacentList[item.Key];
                StringBuilder connections = new StringBuilder();
                foreach (int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }
                Console.WriteLine(item.Key + "-->" + connections);
            }
        }

    }

    internal class GraphImplement
    {
        static void Main()
        {
            var myGraph = new MyGraph();
            myGraph.AddVertex(0);
            myGraph.AddVertex(1);
            myGraph.AddVertex(2);
            myGraph.AddVertex(3);
            myGraph.AddVertex(4);
            myGraph.AddVertex(5);
            myGraph.AddVertex(6);
            myGraph.AddEdge(3, 1);
            myGraph.AddEdge(3, 4);
            myGraph.AddEdge(4, 2);
            myGraph.AddEdge(4, 5);
            myGraph.AddEdge(1, 2);
            myGraph.AddEdge(1, 0);
            myGraph.AddEdge(0, 2);
            myGraph.AddEdge(6, 5);
            myGraph.ShowConnections();
        }
    }
}
