//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Kattis
//{
//	class Program
//	{
//		public static HashSet<string> anagrams = new HashSet<string>();
//		public static void Main()
//		{
//			string line;
//			while ((line = Console.ReadLine()) != null)
//			{
//				char[] arr = line.ToCharArray();
//				Permute(arr, 0, arr.Length - 1);
//				Console.WriteLine(anagrams.Count);
//			}
//		}

//		private static void Swap(ref char a, ref char b)
//		{
//			char tmp = a;
//			a = b;
//			b = tmp;
//		}

//		// SwapUsingBitWise could be used instead of Swap as in the original solution.
//		private static void SwapUsingBitWise(ref char a, ref char b)
//		{
//			if (a == b)
//				return;
//			a ^= b;
//			b ^= a;
//			a ^= b;
//		}

//		private static void Permute(char[] elements, int recursionDepth, int maxDepth)
//		{
//			if (recursionDepth == maxDepth)
//			{
//				Console.WriteLine(elements);
//				anagrams.Add(new string(elements));
//				return;
//			}

//			for (int i = recursionDepth; i <= maxDepth; i++)
//			{
//				Swap(ref elements[recursionDepth], ref elements[i]);
//				Permute(elements, recursionDepth + 1, maxDepth);
//				// backtrack
//				Swap(ref elements[recursionDepth], ref elements[i]);
//			}
//		}
//	}
//}

