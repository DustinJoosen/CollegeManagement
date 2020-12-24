using CollegeManagement.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class CollegeDto : IBase
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
		public string ImageUrl { get; set; }
	}
}
