using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KarateChop
{
	public abstract class Karate
	{
		public abstract int Chop(int n, int[] array);
	}


	// First implementation of binary search
	public class SimpleKarate : Karate
	{
		// Binary search using indices manipulation
		public override int Chop(int n, int[] array)
		{

			int start = 0;
			int lenght = array.Length;
			int end = lenght - 1;

			while(start <= end)
			{
				int mid = ((end - start) / 2) + start;

				if (array[mid] == n)
					return mid;

				if(array[mid] > n)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}

			return -1;
		}
	}

	// Recursive implementation of binary search
	public class RecursiveKarate : Karate
	{
		public override int Chop(int n, int[] array)
		{
			int mid = array.Length / 2;

			if (array.Length == 0)
				return -1;

			if (array[mid] == n)
				return mid;
			else
			{
				if (array.Length == 1)
					return -1;

				int start, end;

				if(n > array[mid]) // If searched element may be found at right of mid
				{
					start = mid + 1;
					end = array.Length - 1;
				}
				else // If searched element may be found at left of mid
				{
					start = 0;
					end = mid - 1;
				}

				// Calculate the length of the new chopped array
				int newLength = end - start + 1;

				int[] newArray = new int[newLength];
				// Copy half the original array to the new array
				Array.Copy(array, start, newArray, 0, newLength);


				var index = Chop(n, newArray);
				// Checks if call found the element. 
				// Returns the index + start position if found, -1 otherwise
				return (index == -1) ? -1 : index + start;
			}
		}
	}

	public class Program
	{
		static int Chop(int n, int[] array)
		{
			return -1;
		}

		static void Main(string[] args)
		{
			// Karate karate = new SimpleKarate();
			Karate karate = new RecursiveKarate();

			var index = karate.Chop(4, new int[] {1, 3, 5, 7 });

			return;
		}	
	}
}

