namespace KarateChop
{
	public interface IKarateChop
    {
		/// <summary>
		/// Write a binary chop method that takes an integer search target and a sorted array of integers.
		/// </summary>
		/// <remarks>http://codekata.com/kata/kata02-karate-chop/</remarks>
		/// <param name="searchValue">Integer search target.</param>
		/// <param name="values">Sorted array of integers.</param>
		/// <returns>It should return the integer index of the target in the array, or -1 if the target is not in the array.</returns>
		int Chop(int searchValue, int[] values);
	}
}
