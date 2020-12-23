using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Models
{
	public class Building
	{
		public int Id { get; set; }

		public College College { get; set; }
		public int CollegeId { get; set; }
		
		public string Name { get; set; }
		public string Address { get; set; }
		public string ZipCode { get; set; }
		public string Info { get; set; }
	}
}
