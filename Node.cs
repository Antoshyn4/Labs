using System;

public class Node<T> where T : IComparable
{
	public T Data { set; get; }
	public Node<T> Left { get; private set; }
	public Node<T> Right { get; private set; }
	public Node<T>()
	{
		sos
	}
}
