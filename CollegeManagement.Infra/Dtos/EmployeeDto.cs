﻿using CollegeManagement.Infra.Enums;
using CollegeManagement.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class EmployeeDto : IBase, ICollege
	{
		public int Id { get; set; }

		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public BuildingDto Building { get; set; }
		public int BuildingId { get; set; }

		public EmployeeType EmployeeType { get; set; }
		public string Firstname { get; set; }
		public string Middlename { get; set; }
		public string Lastname { get; set; }
		public string Fullname
		{
			get
			{
				return String.IsNullOrEmpty(Middlename) ? $"{Firstname} {Lastname}" : $"{Firstname} {Middlename} {Lastname}";
			}
		}

		public DateTime DateOfBirth { get; set; }
		public DateTime DateOfEmployement { get; set; }
		public bool Active { get; set; }
		public string EmailAddress { get; set; }
		public string ImageName { get; set; }
		public string ImageUrl { get; set; }
	}
}
