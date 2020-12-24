﻿using CollegeManagement.Infra.Interfaces;
using CollegeManagement.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class StudentTeacherDto : ICollege
	{
		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public StudentDto Student { get; set; }
		public int StudentId { get; set; }

		public int TeacherId { get; set; }

		public RelationType RelationType { get; set; }
	}
}
