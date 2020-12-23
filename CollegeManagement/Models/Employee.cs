using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Models
{
	public class Employee
	{
		public int Id { get; set; }

		public College College { get; set; }
		public int CollegeId { get; set; }

		public Building Building { get; set; }
		public int BuildingId { get; set; }

		public int EmployeeType { get; set; }
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
