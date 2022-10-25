using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnibblesd6
{
    internal class nibbles
    {
		static void showArr(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			Console.WriteLine();
		}
		static boolean powerOf2(int n)
		{
			int i = 0, temp = (int)Math.Pow(2, i);
			while (temp < n)
			{
				if (temp == n)
				{
					return true;
				}
				i++;
			}
			return false;
		}
		static int[] swapNibbles(int[] arr)
		{
			int temp, j = arr.Length - 4;
			for (int i = 0; i < 4; i++)
			{ 
				temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				j++;
			}
			return arr;
		}
		public static void main(String[] args)
		{

			try
			{
				Scanner s = new Scanner(System.in);
				Console.WriteLine("enter a no");
				int[] binary = Util.toBinary(s.nextInt());
				Console.WriteLine("binary is ");
				showArr(binary);
				s.close();
				swapNibbles(binary);
				Console.WriteLine("after swapping ");
				showArr(binary);
				int swapDec = Util.toDecimal(binary);
			   Console.WriteLine("decimal of swapped binary is " + swapDec);

				if (powerOf2(swapDec))
					Console.WriteLine("its power of 2");
			else
					Console.WriteLine("not power of 2");

			}
			catch (Exception e)
			{
				Console.WriteLine("enter input as integer ");
			}

		}
	}

    internal class Scanner
    {
        internal void close()
        {
            throw new NotImplementedException();
        }

        internal object nextInt()
        {
            throw new NotImplementedException();
        }
    }

    internal class boolean
    {
    }
}
