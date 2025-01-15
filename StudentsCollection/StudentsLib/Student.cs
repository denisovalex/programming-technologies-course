namespace StudentsLib
{
	public class Student
	{
		public string Name { get; private set; }
		public string Surname { get; private set; }
		public string Patronymic { get; private set; }
		public SexEnum Sex { get; private set; }
		public DateTime Birth { get; private set; }
		public string Group { get; private set; }
		public int Course { get; private set; }
		public EGE Ege { get; private set; }

		public Student(string name, string surname, string patronymic, SexEnum sex, DateTime birth, string group, int course, int egeM, int egeI, int egeR)
		{
			Name = name;
			Surname = surname;
			Patronymic = patronymic;
			Sex = sex;
			Birth = birth;
			Group = group;
			Course = course;
			Ege = new EGE(egeM, egeI, egeR);
		}

		public void UpgradeCourse()
		{
			Course++;
		}

		public bool isEarthy()
		{
			if (isTaurus() || isVirgo() || isCapricorn())
				return true;
			return false;
		}

		private bool isTaurus()
		{
			if (((Birth.Month == 4) && (Birth.Day >= 21)) || ((Birth.Month == 5) && (Birth.Day <= 21)))
				return true;
			return false;
		}

		private bool isVirgo()
		{
			if (((Birth.Month == 8) && (Birth.Day >= 23)) || ((Birth.Month == 9) && (Birth.Day <= 23)))
				return true;
			return false;
		}

		private bool isCapricorn()
		{
			if (((Birth.Month == 12) && (Birth.Day >= 21)) || ((Birth.Month == 1) && (Birth.Day <= 19)))
				return true;
			return false;
		}
	}
}
