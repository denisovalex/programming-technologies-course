using HeapifyBinaryTree;

var tree = new BinaryTree<int>();
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(2);
tree.Add(4);
tree.Add(6);
tree.Add(8);

tree.PrintTree();
Console.WriteLine("\n\n\n\n");

tree.Remove(4);
tree.Remove(7);

tree.PrintTree();