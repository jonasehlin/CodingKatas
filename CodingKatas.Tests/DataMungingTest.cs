using DataMunging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingKatas.Tests
{
	[TestClass]
	public class DataMungingTest
	{
		[TestMethod]
		public void DataFileLoad()
		{
			var dataFile = new DataFile();
			dataFile.LoadFromString(DataMunging.Properties.Resources.weather);
			Assert.AreEqual(17, dataFile.Columns.Count, "Wrong number of columns.");
			Assert.AreEqual("Dy", dataFile.Columns[0], "Wrong first column text.");
			Assert.AreEqual(31, dataFile.Rows.Count, "Wrong number of rows.");
		}
	}
}
