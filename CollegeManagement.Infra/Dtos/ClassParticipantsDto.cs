using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeManagement.Infra.Dtos
{
	public class ClassParticipantsDto
	{
		public EmployeeDto Mentor { get; set; }
		public List<StudentDto> Students{ get; set; }
	}
}
