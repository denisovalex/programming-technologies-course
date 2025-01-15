using StudentsLib;

class Program
{
	static void Main()
	{
		BaseRealisation();
		//HigherDifficultyRealisation();
	}

	static void BaseRealisation()
	{
		var random = new Random();

		var students = new List<Student>();

		// Симуляция пяти учебных лет
		for (int i = 20; i <= 24; i++)
		{
			foreach (var student in students.FindAll(s => s.Course == 4)) // отчисление 4-го курса
			{
				students.Remove(student);
			}

			foreach (var student in students) // повышение курса у оставшихся
			{
				student.UpgradeCourse();
			}

			var newStudentsAmount = random.Next(100);
			for (int j = 0; j <= newStudentsAmount; j++) // зачисление на 1-ый курс
			{
				var newStudent = GenerateStudent(i);
				students.Add(newStudent);
			}
		}

		// Выборка "земных"
		var earthyStudents = students.FindAll(s => s.isEarthy());

		// Печать выборки на консоль
		foreach (var student in earthyStudents)
		{
			Console.WriteLine($"{student.Name} {student.Surname}, {student.Birth.ToString("d")}г.");
		}
	}

	static void HigherDifficultyRealisation()
	{
		var random = new Random();

		var students = new Dictionary<int, List<Student>>();

		// Симуляция пяти учебных лет
		for (int i = 20; i <= 24; i++)
		{
			foreach (var studentBunch in students) // отчисление 4-го курса
			{
				foreach (var student in studentBunch.Value)
				{
					if (student.Course == 4)
						studentBunch.Value.Remove(student);
				}
			}

			foreach (var studentBunch in students) // повышение курса у оставшихся
			{
				foreach (var student in studentBunch.Value)
				{
					student.UpgradeCourse();
				}
			}

			var newStudentsAmount = random.Next(100);
			for (int j = 0; j <= newStudentsAmount; j++) // зачисление на 1-ый курс
			{
				var newStudent = GenerateStudent(i);
				var key = Convert.ToInt32(newStudent.Birth.Month);
				
				if (students.ContainsKey(key))
				{
					students[key].Add(newStudent);
				}
				else
				{
					students.Add(key, new List<Student> { newStudent });
				}
			}
		}

		// Выборка "земных"

		var earthyKeys = new int[] { 4, 5, 8, 9, 12, 1 };
		var earthyStudents = new List<Student>();

		foreach (var key in earthyKeys)
		{
			if (students.ContainsKey(key))
			{
				 foreach (var student in students[key].FindAll(s => s.isEarthy()))
				{
					earthyStudents.Add(student);
				}
			}
		}
		
		// Печать выборки на консоль
		foreach (var student in earthyStudents)
		{
			Console.WriteLine($"{student.Name} {student.Surname}, {student.Birth.ToString("d")}г.");
		}
	}

	static Student GenerateStudent(int year)
	{
		var random = new Random();

		if (random.Next(2) == 0)
		{
			string[] names = { "Анна", "Екатерина", "Мария", "Ольга", "Наталья", "София", "Алиса" };
			string[] surnames = { "Иванова", "Смирнова", "Кузнецова", "Петрова", "Соколова", "Михайлова", "Новикова", "Федорова", "Морозова", "Волкова" };
			string[] patronymics = { "Александровна", "Сергеевна", "Ивановна", "Дмитриевна", "Николаевна" };

			string[] groups = { "БИСТ-", "БИВТ-", "БПИ-" };

			return new Student(names[random.Next(names.Length)],
				surnames[random.Next(surnames.Length)],
				patronymics[random.Next(patronymics.Length)],
				SexEnum.Female,
				new DateTime(random.Next(2000, 2006), random.Next(1, 13), random.Next(1, 28)),
				groups[random.Next(groups.Length)] + year.ToString(),
				1,
				random.Next(55, 101),
				random.Next(55, 101),
				random.Next(55, 101));
		}
		else
		{
			string[] names = { "Иван", "Александр", "Михаил", "Сергей", "Андрей", "Николай", "Дмитрий" };
			string[] surnames = { "Иванов", "Смирнов", "Кузнецов", "Петров", "Соколов", "Михайлов", "Новиков", "Федоров", "Морозов", "Волков" };
			string[] patronymics = { "Иванович", "Александрович", "Сергеевич", "Михайлович", "Николаевич" };

			string[] groups = { "БИСТ-", "БИВТ-", "БПИ-" };

			return new Student(names[random.Next(names.Length)],
				surnames[random.Next(surnames.Length)],
				patronymics[random.Next(patronymics.Length)],
				SexEnum.Male,
				new DateTime(random.Next(2000, 2006), random.Next(1, 13), random.Next(1, 28)),
				groups[random.Next(groups.Length)] + year.ToString(),
				1,
				random.Next(55, 101),
				random.Next(55, 101),
				random.Next(55, 101));
		}
	}
}
