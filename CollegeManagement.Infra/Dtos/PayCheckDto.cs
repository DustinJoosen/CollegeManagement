using CollegeManagement.Infra.Interfaces;
using CollegeManagement.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class PayCheckDto : IBase, ICollege
	{
		public int Id { get; set; }

		public CollegeDto College { get; set; }
		public int CollegeId { get; set; }

		public EmployeeDto Employee { get; set; }
		public int EmployeeId { get; set; }

		public decimal Amount { get; set; }
		public PaymentStatus Status { get; set; }
		public string SpecialNotes { get; set; }
	}
}
