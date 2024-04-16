using cISort;
using clIMath;
using InterfaceP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clArray
{
	internal class ClassArray : IOutput, IMath, ISort
	{

		public int[] arr;
		public int Length;
		public ClassArray(params int[] elements)
		{
			arr = elements;
			Length = elements.Length;
		}

		public void Show()
		{
			Console.WriteLine("Elements of the array:");
			for (int i = 0; i < Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
		public void Show(string info)
		{
			Console.WriteLine("Elements of the array:");
			for (int i = 0; i < Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine($"{info}");
		}

		public int Max()
		{
			int maxValue = int.MinValue;
			for (int i = 0; i < Length; i++)
			{
				if (arr[i] > maxValue)
				{
					maxValue = arr[i];
				}
			}
			return maxValue;
		}
		public int Min()
		{
			int minValue = int.MaxValue;
			for (int i = 0; i < Length; i++)
			{
				if (arr[i] < minValue)
				{
					minValue = arr[i];
				}
			}
			return minValue;
		}

		public float Avg()
		{
			float sum = 0;
			for (int i = 0; i < Length; i++)
			{
				sum += arr[i];
			}
			return sum / Length;
		}

		public bool Search(int valueToSearch)
		{
			for (int i = 0; i < Length; i++)
			{
				if (valueToSearch == arr[i])
				{
					return true;
				}
			}
			return false;
		}

		public void SortAsc()
		{
			Console.WriteLine("Sort array ascending: ");
			for (int i = 0; i < Length; i++)
			{
				for (int j = i + 1; j < Length; j++)
				{
					if (arr[i] > arr[j])
					{
						int temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
				}
				Console.Write(arr[i] + " ");
			}
		}
		public void SortDesc()
		{
			Console.WriteLine("\nSort array descending: ");
			for (int i = 0; i < Length; i++)
			{
				for (int j = i + 1; j < Length; j++)
				{
					if (arr[i] < arr[j])
					{
						int temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
				}
				Console.Write(arr[i] + " ");
			}
		}
		public void SortByParam(bool isAsc)
		{
			if (isAsc)
			{
				SortAsc();
			}
			else if(!isAsc)
			{
				SortDesc();
			}
		}

	}
}
