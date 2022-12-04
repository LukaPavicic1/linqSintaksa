﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace linqSintaksa
{
    public class Program
    {
		public static void Main()
		{
			
			List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John" } ,
				new Student() { StudentID = 2, StudentName = "Moin" } ,
				new Student() { StudentID = 3, StudentName = "Bill" } ,
				new Student() { StudentID = 4, StudentName = "Ram"  } ,
				new Student() { StudentID = 5, StudentName = "Ron"  }
			};

			var result = studentList.Where(s => s.StudentName.Contains("n"));

			foreach (var s in result)
			{
				Console.WriteLine(s.StudentName);
			}

				Console.ReadKey();
		}
	}
	public class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
	}
}
