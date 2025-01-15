using App.BinaryTree;

namespace App.IO
{
	public static class TreePrinter
	{
		public static void Print(BinaryTree<int> tree)
		{
			PrintRec(tree.Root, 0);
		}

		private static void PrintRec(TreeNode<int>? node, int indent)
		{
			if (node == null)
				return;

			PrintRec(node.Right, indent + 4);

			Console.Write("\n");
			Console.Write(new string(' ', indent));
			Console.Write(node.Value + "\n");

			PrintRec(node.Left, indent + 4);
		}
	}
}
