using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyZaliczenie
{
	internal class LinkedList
	{
		Node first = null;
		public Object First
		{
			get { return first?.Data; }
		}
		public void AddFirst(Object data)
		{
			first = new Node(data, first);
		}
		public Object RemoveFirst()
		{
			Node oldNode = first;
			if (oldNode == null)
				return null;
			first = oldNode.Next;
			return oldNode.Data;
		}
		public void AddLast(Object data)
		{
			//todo
		}
		class Node
		{
			public Object Data;
			public Node Next;
			public Node(Object data, Node next)
			{
				Data = data;
				Next = next;
			}
		}
	}
}
