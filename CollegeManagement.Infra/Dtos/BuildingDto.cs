using CollegeManagement.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class BuildingDto : IBase, ICollege
	{
		public int Id { get; set; }

		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public string Name { get; set; }
		public string Address { get; set; }
		public string ZipCode { get; set; }
		public string Info { get; set; }

	}
}

