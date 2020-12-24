using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Infra.Enums;
using CollegeManagement.Infra.Interfaces;

namespace CollegeManagement.Api.Models
{
	public class Employee : ICollege, IBase
	{
		public int Id { get; set; }

		public College College { get; set; }
		public int CollegeId { get; set; }

		public Building Building { get; set; }
		public int BuildingId { get; set; }

		//public Education Education{ get; set; }
		//public int EducationId { get; set; }

		public EmployeeType EmployeeType { get; set; }
		public string Firstname { get; set; }
		public string Middlename { get; set; }
		public string Lastname { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime DateOfEmployement { get; set; }
		public bool Active { get; set; }
		public string EmailAddress { get; set; }
		public string ImageName { get; set; }
	}
}
