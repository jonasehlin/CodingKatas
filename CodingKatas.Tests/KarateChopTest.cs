using KarateChop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingKatas.Tests
{
	[TestClass]
	public class KarateChopTest
	{
		[TestMethod]
		public void IterativeKarateChops()
		{
			TestChops(new IterativeKarateChop());
		}

		[TestMethod]
		public void RecursiveKarateChops()
		{
			TestChops(new RecursiveKarateChop());
		}

		private static void TestChops(IKarateChop karate)
		{
			Assert.AreEqual(-1, karate.Chop(3, new int[] { }));
			Assert.AreEqual(-1, karate.Chop(3, new int[] { 1 }));
			Assert.AreEqual(0, karate.Chop(1, new int[] { 1 }));

			Assert.AreEqual(0, karate.Chop(1, new int[] { 1, 3, 5 }));
			Assert.AreEqual(1, karate.Chop(3, new int[] { 1, 3, 5 }));
			Assert.AreEqual(2, karate.Chop(5, new int[] { 1, 3, 5 }));
			Assert.AreEqual(-1, karate.Chop(0, new int[] { 1, 3, 5 }));
			Assert.AreEqual(-1, karate.Chop(2, new int[] { 1, 3, 5 }));
			Assert.AreEqual(-1, karate.Chop(4, new int[] { 1, 3, 5 }));
			Assert.AreEqual(-1, karate.Chop(6, new int[] { 1, 3, 5 }));

			Assert.AreEqual(0, karate.Chop(1, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(1, karate.Chop(3, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(2, karate.Chop(5, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(3, karate.Chop(7, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(-1, karate.Chop(0, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(-1, karate.Chop(2, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(-1, karate.Chop(4, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(-1, karate.Chop(6, new int[] { 1, 3, 5, 7 }));
			Assert.AreEqual(-1, karate.Chop(8, new int[] { 1, 3, 5, 7 }));

			Assert.AreEqual(0, karate.Chop(1, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(1, karate.Chop(2, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(2, karate.Chop(3, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(3, karate.Chop(5, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(4, karate.Chop(7, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(5, karate.Chop(11, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(6, karate.Chop(13, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(7, karate.Chop(17, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(8, karate.Chop(19, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));

			Assert.AreEqual(-1, karate.Chop(-1, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(-1, karate.Chop(15, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
			Assert.AreEqual(-1, karate.Chop(30, new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 }));
		}
	}
}
