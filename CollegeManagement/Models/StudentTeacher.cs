using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Models
{
	public class StudentTeacher
	{
		public College College { get; set; }
		public int CollegeId { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		//public Employee Teacher { get; set; }
		public int TeacherId { get; set; }

		public int RelationType { get; set; }
	}
}
