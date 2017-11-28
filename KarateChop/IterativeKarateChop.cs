using System;

namespace KarateChop
{
	public class IterativeKarateChop : IKarateChop
	{
		public int Chop(int searchValue, int[] values)
		{
			if (values == null || values.Length == 0)
				return -1;

			int start = 0;
			int length = values.Length;
			while (length > 0)
			{
				int i = (start + length) / 2;
				if (values[i] == searchValue)
					return i;
			}

			return -1;
		}
	}
}
