using CollegeManagement.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class StudentDto : ICollege, IBase
	{
		public int Id { get; set; }

		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public BuildingDto Building { get; set; }
		public int BuildingId { get; set; }

		public ClassDto Class { get; set; }
		public int ClassId { get; set; }

		public string Firstname { get; set; }
		public string Middlename { get; set; }
		public string Lastname { get; set; }
		public DateTime DateOfBirth { get; set; }
		public bool Active { get; set; }
		public string EmailAddress { get; set; }
		public string ImageName { get; set; }
		public string ImageUrl { get; set; }
	}
}
