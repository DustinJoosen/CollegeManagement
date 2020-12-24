﻿using CollegeManagement.Api.Models;
using CollegeManagement.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Services
{
	public class CollegeService : Service<College>, ICollegeService
	{
		public CollegeService(ICollegeRepository repos) : base (repos)
		{

		}
	}
}
