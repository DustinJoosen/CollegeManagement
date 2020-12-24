using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Infra.Enums;
using CollegeManagement.Infra.Interfaces;


namespace CollegeManagement.Api.Models
{
	public class StudentTeacher : ICollege
	{
		public College College { get; set; }
		public int CollegeId { get; set; }

		public Student Student { get; set; }
		public int StudentId { get; set; }

		public int TeacherId { get; set; }

		public RelationType RelationType { get; set; }
	}
}
