namespace KarateChop
{
	public class IterativeKarateChop : IKarateChop
	{
		public int Chop(int searchValue, int[] values)
		{
			if (values == null || values.Length == 0)
				return -1;

			int begin = 0;
			int end = values.Length;
			while (begin != end)
			{
				int i = (begin + end) / 2;
				if (values[i] == searchValue)
					return i;
				else if (searchValue < values[i])
					end = i;
				else
					begin = i + 1;
			}

			return -1;
		}
	}
}
