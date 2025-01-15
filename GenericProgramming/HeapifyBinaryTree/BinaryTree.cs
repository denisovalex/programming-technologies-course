using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapifyBinaryTree
{
	public class BinaryTree<T> where T : IComparable<T>
	{
		private List<T> heap;

		public BinaryTree()
		{
			heap = new List<T>();
		}

		public void Add(T data)
		{
			heap.Add(data);
			HeapifyUp(heap.Count - 1);
		}

		public void Remove(T data)
		{
			if (heap.Count == 0)
				return;

			int indexToRemove = heap.IndexOf(data);
			if (indexToRemove == -1)
				return;

			int lastIndex = heap.Count - 1;
			heap[indexToRemove] = heap[lastIndex];
			heap.RemoveAt(lastIndex);

			if (indexToRemove < heap.Count)
			{
				HeapifyDown(indexToRemove);
				HeapifyUp(indexToRemove);
			}
		}

		public void PrintTree()
		{
			PrintTree(0, 0);
		}

		private void HeapifyUp(int index)
		{
			int parentIndex = (index - 1) / 2;

			if (index > 0 && heap[index].CompareTo(heap[parentIndex]) > 0)
			{
				Swap(index, parentIndex);
				HeapifyUp(parentIndex);
			}
		}

		private void Swap(int index1, int index2)
		{
			T temp = heap[index1];
			heap[index1] = heap[index2];
			heap[index2] = temp;
		}

		private void HeapifyDown(int index)
		{
			int leftChildIndex = index * 2 + 1;
			int rightChildIndex = index * 2 + 2;
			int largestIndex = index;

			if (leftChildIndex < heap.Count && heap[leftChildIndex].CompareTo(heap[largestIndex]) > 0)
				largestIndex = leftChildIndex;

			if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[largestIndex]) > 0)
				largestIndex = rightChildIndex;

			if (largestIndex != index)
			{
				Swap(largestIndex, index);
				HeapifyDown(largestIndex);
			}
		}

		private void PrintTree(int currentIndex, int level)
		{
			if (currentIndex >= heap.Count)
				return;

			PrintTree(currentIndex * 2 + 2, level + 1);

			string indent = new string(' ', level * 4);
			Console.WriteLine(indent + heap[currentIndex]);

			PrintTree(currentIndex * 2 + 1, level + 1);
		}
	}
}
