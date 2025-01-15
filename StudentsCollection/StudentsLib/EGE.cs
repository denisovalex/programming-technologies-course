namespace StudentsLib
{
	public class EGE
	{
		public int Math { get; private set; }
		public int Informatics { get; private set; }
		public int Russian { get; private set; }

		public EGE(int math, int informatics, int russian)
		{
			Math = math;
			Informatics = informatics;
			Russian = russian;
		}
	}
}
