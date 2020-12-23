using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Models
{
	public class Class
	{
		public int Id { get; set; }

		public College College{ get; set; }
		public int CollegeId { get; set; }

		public Building Building{ get; set; }
		public int BuildingId { get; set; }

		//public Employee Mentor{ get; set; }
		public int MentorId { get; set; }

		public string Name { get; set; }
		public DateTime DateStarted { get; set; }
	}
}