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

	public class Program
	{
		static int Chop(int n, int[] array)
		{
			return -1;
		}

		static void Main(string[] args)
		{
			SimpleKarate simpleKarate = new SimpleKarate();

			simpleKarate.Chop(0, new int[] {1, 3, 5});
		}	
	}
}

