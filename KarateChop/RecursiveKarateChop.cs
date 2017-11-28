using System;

namespace KarateChop
{
	public class RecursiveKarateChop : IKarateChop
	{
		public int Chop(int searchValue, int[] values)
		{
			if (values == null || values.Length == 0)
				return -1;

			int i = values.Length / 2;
			if (values[i] == searchValue)
				return i;
			else if (searchValue < values[i])
			{
				return Chop(searchValue, values.SubArray(0, i));
			}
			else
			{
				int result = Chop(searchValue, values.SubArray(i + 1, values.Length - i - 1));
				return result == -1 ? -1 : i + 1 + result;
			}
		}
	}

	static class ArrayHelper
	{
		public static T[] SubArray<T>(this T[] source, int index, int length)
		{
			if (source == null || length == 0 || source.Length == 0 || length > source.Length)
				return null;

			T[] target = new T[length];
			Array.Copy(source, index, target, 0, length);
			return target;
		}
	}
}
