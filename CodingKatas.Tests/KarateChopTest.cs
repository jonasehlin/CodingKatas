using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KarateChop;

namespace CodingKatas.Tests
{
	[TestClass]
	public class KarateChopTest
	{
		[TestMethod]
		public void KarateChops()
		{
			IKarateChop karateChop = null;

			Assert.Equals(-1, karateChop.Chop(3, new int[] { }));
			Assert.Equals(-1, karateChop.Chop(3, new int[] { 1 }));
			Assert.Equals(0, karateChop.Chop(1, new int[] { 1 }));

			//Assert.Equals(0, karateChop.Chop(1, [1, 3, 5]));
			//Assert.Equals(1, karateChop.Chop(3, [1, 3, 5]));
			//Assert.Equals(2, karateChop.Chop(5, [1, 3, 5]));
			//Assert.Equals(-1, karateChop.Chop(0, [1, 3, 5]));
			//Assert.Equals(-1, karateChop.Chop(2, [1, 3, 5]));
			//Assert.Equals(-1, karateChop.Chop(4, [1, 3, 5]));
			//Assert.Equals(-1, karateChop.Chop(6, [1, 3, 5]));

			//Assert.Equals(0, karateChop.Chop(1, [1, 3, 5, 7]));
			//Assert.Equals(1, karateChop.Chop(3, [1, 3, 5, 7]));
			//Assert.Equals(2, karateChop.Chop(5, [1, 3, 5, 7]));
			//Assert.Equals(3, karateChop.Chop(7, [1, 3, 5, 7]));
			//Assert.Equals(-1, karateChop.Chop(0, [1, 3, 5, 7]));
			//Assert.Equals(-1, karateChop.Chop(2, [1, 3, 5, 7]));
			//Assert.Equals(-1, karateChop.Chop(4, [1, 3, 5, 7]));
			//Assert.Equals(-1, karateChop.Chop(6, [1, 3, 5, 7]));
			//Assert.Equals(-1, karateChop.Chop(8, [1, 3, 5, 7]));
		}
	}
}
