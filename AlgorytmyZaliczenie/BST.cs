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
			if(this.Root == null)
            {
				this.Root = new Node(key, null, null, null);
				return;
            }
			Node node = this.Root;
			while(true)
            {
				if(key < node.Key)
                {
					if(node.Left == null)
                    {
						node.Left = new Node(key, node, null, null);
						return;

					}
					else
					{
						node = node.Left;
					}
				}
                else
                {
					if(node.Right == null)
                    {
						node.Right = new Node(key, node, null, null);
						return;
                    }
                    else
                    {
						node = node.Right;
                    }
                }
            }
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
	}
	internal class Node
	{
		public Node Parent = null, Left = null, Right = null;
		public int Key;
		public Node(int key, Node parent = null)
		{
			Key = key;
			Parent = parent;
		}
		public Node(int key, Node parent, Node left, Node right)
        {
			this.Key = key;
			this.Parent = parent;
			this.Left = left;
			this.Right = right;
        }
	}
}
