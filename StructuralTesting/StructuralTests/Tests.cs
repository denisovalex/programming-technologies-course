namespace StructuralTests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void IsSelfIntersectingTrueTest()
		{
			var polygon = new Polygon(
				new List<Point>() { new Point(1, 1), 
					new Point(2, 3), 
					new Point(4, 4), 
					new Point(6, 2), 
					new Point(1, 2) }
				);

			Assert.IsTrue(polygon.IsSelfIntersecting());
		}

		[TestMethod]
		public void IsSelfIntersectingFalseTest()
		{
			var polygon = new Polygon(
				new List<Point>() { new Point(1, 1),
					new Point(2, 3),
					new Point(4, 4),
					new Point(6, 2),
					new Point(2, 1) }
				);

			Assert.IsFalse(polygon.IsSelfIntersecting());
		}
	}
}
