using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyZaliczenie
{
	internal class BST
	{
		Node Root = null;
		public void Add(int key)
		{
			//todo
		}
		public bool Contains(int key)
		{
			Node node = Root;
			while (node != null)
				if (key == node.Key)
					return true;
				else if (key < node.Key)
					node = node.Left;
				else
					node = node.Right;
			return false;
		}
		class Node
		{
			public Node
				Parent = null,
				Left = null,
				Right = null;
			public int
				Key;
			public Node(
				int key,
				Node parent = null
			)
			{
				Key = key;
				Parent = parent;
			}
		}
	}
}
