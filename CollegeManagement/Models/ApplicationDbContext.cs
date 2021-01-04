using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Api.Models
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<College> Colleges { get; set; }
		public DbSet<Building> Buildings { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<PayCheck> PayChecks { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<StudentTeacher> StudentTeachers { get; set; }
		//public DbSet<Education> Educations{ get; set; }
		//public DbSet<Subject> Subjects { get; set; }
		//public DbSet<Lesson> Lessons { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Group>()
				.HasOne<Employee>()
				.WithMany()
				.HasForeignKey(s => s.MentorId);

			modelBuilder.Entity<StudentTeacher>()
				.HasOne<Employee>()
				.WithMany()
				.HasForeignKey(s => s.TeacherId);

			//modelBuilder.Entity<Lesson>()
			//	.HasOne<Employee>()
			//	.WithMany()
			//	.HasForeignKey(s => s.TeacherId);

		}

		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
	}
}
