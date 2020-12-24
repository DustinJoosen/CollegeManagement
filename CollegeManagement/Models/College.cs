using CollegeManagement.Infra.Interfaces;

namespace CollegeManagement.Api.Models
{
	public class College : IBase
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
	}
}
