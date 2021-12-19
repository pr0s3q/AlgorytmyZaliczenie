namespace AlgorytmyZaliczenie
{
    internal class LinkedList
	{
		Node_? first;
		Node_? last;
		public LinkedList()
        {
			first = null;
			last = null;
		}
		public Object First
		{
			get { return this.first?.Data; }
		}
		public void AddFirst(Object data)
		{
			first = new Node_(data, first);
		}
		public Object RemoveFirst()
		{
			Node_ oldNode = first;
			if (oldNode == null)
				return null;
			first = oldNode.Next;
			return oldNode.Data;
		}
		public void AddLast(Object data)
		{
			last = new Node_(data, last);
		}
	}
	internal class Node_
	{
		public Object Data;
		public Node_ Next;
		public Node_(Object data, Node_ next)
		{
			Data = data;
			Next = next;
		}
	}
}
