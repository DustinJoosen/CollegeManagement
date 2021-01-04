using CollegeManagement.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class GroupDto : IBase, ICollege
	{
		public int Id { get; set; }

		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public BuildingDto Building { get; set; }
		public int BuildingId { get; set; }

		public int MentorId { get; set; }

		public string Name { get; set; }
		public DateTime DateStarted { get; set; }
	}
}
