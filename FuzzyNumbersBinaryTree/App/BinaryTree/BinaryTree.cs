namespace App.BinaryTree
{
	public class BinaryTree<T>
	{
		public TreeNode<T>? Root { get; private set; }

		public BinaryTree()
		{
			Root = null;
		}

		public BinaryTree(T rootValue)
		{
			Root = new TreeNode<T>(rootValue);
		}

		public void Insert(T value)
		{
			Root = InsertRec(Root, value);
		}

		private TreeNode<T> InsertRec(TreeNode<T>? node, T value)
		{
			if (node == null)
			{
				node = new TreeNode<T>(value);
				return node;
			}

			int comparison = Comparer<T>.Default.Compare(value, node.Value);
			if (comparison < 0)
			{
				node.Left = InsertRec(node.Left, value);
			}
			else if (comparison > 0)
			{
				node.Right = InsertRec(node.Right, value);
			}
			return node;
		}

		public void Remove(T value)
		{
			Root = RemoveRec(Root, value);
		}

		private TreeNode<T>? RemoveRec(TreeNode<T>? node, T value)
		{
			if (node == null) return node;

			int comparison = Comparer<T>.Default.Compare(value, node.Value);
			if (comparison < 0)
			{
				node.Left = RemoveRec(node.Left, value);
			}
			else if (comparison > 0)
			{
				node.Right = RemoveRec(node.Right, value);
			}
			else
			{
				// Узел с одним потомком или без потомков
				if (node.Left == null) return node.Right;
				else if (node.Right == null) return node.Left;

				// Узел с двумя потомками: получение наименьшего значения в правом поддереве
				node.Value = MinValue(node.Right);

				// Удаление наименьшего узла в правом поддереве
				node.Right = RemoveRec(node.Right, node.Value);
			}
			return node;
		}

		private T MinValue(TreeNode<T> node)
		{
			T minValue = node.Value;
			while (node.Left != null)
			{
				minValue = node.Left.Value;
				node = node.Left;
			}
			return minValue;
		}
	}
}
