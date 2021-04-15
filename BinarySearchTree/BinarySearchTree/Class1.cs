using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
	public class Node<T> : IComparable
		where T : IComparable
	{
		public T Data { set; get; }
		public Node<T> Left { get; private set; }
		public Node<T> Right { get; private set; }
		public Node(T data)
		{
			Data = data;
		}
		public Node(T data, Node<T> left, Node<T> right)
		{
			Data = data;
			Left = left;
			Right = right;
		}

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
				return Data.CompareTo(item.Data);
            }
            else
            {
				throw new ArgumentException("Не совпаднеие типов");
            }
        }
    }
}
