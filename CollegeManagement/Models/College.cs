﻿using CollegeManagement.Infra.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Models
{
	public class College : IBase
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
	}
}