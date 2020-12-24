﻿using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Repositories
{
	public class StudentTeacherRepository : GenericCollegeRepository<StudentTeacher>, IStudentTeacherRepository
	{
		public StudentTeacherRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
