using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Infra.Enums;
using CollegeManagement.Infra.interfaces;


namespace CollegeManagement.Api.Models
{
	public class PayCheck : ICollege, IBase
	{
		public int Id { get; set; }

		public College College { get; set; }
		public int CollegeId { get; set; }

		public Employee Employee { get; set; }
		public int EmployeeId { get; set; }

		public decimal Amount { get; set; }
		public PaymentStatus Status { get; set; }
		public string SpecialNotes { get; set; }
	}
}