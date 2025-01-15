namespace FunctionalTests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void ArgumentExceptionTest()
		{
			string[] args = { "", "other args" };
			Assert.ThrowsException<ArgumentException>(() => Program.Main(args));
		}

		[TestMethod]
		public void FileNotFoundExceptionTest()
		{
			string[] args = { "C:\\some.txt", "other args" };
			Assert.ThrowsException<FileNotFoundException>(() => Program.Main(args));
		}

		[TestMethod]
		public void IOExceptionTest()
		{
			string[] args = { "C:\\so?me.txt", "other args" };
			Assert.ThrowsException<IOException>(() => Program.Main(args));
		}

		[TestMethod]
		public void CorrectPathTest()
		{
			string[] args = { "D:\\some.txt", "other args" };
			Assert.(() => Program.Main(args));
		}
	}
}