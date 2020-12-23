using System;

namespace CollegeManagement.Infra.Enums
{
	public enum EmployeeType
	{
		Teacher,
		Janitor,
		TechSupport,
		Administration
	}

	public enum PaymentStatus
	{
		Payed,
		NotPayed,
		Processing
	}

	public enum RelationType
	{
		TeacherStudent,
		MentorStudent
	}
}
