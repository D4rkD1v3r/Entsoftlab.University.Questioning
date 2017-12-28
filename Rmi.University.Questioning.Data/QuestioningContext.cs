using Microsoft.EntityFrameworkCore;
using Rmi.University.Questioning.Data.Models;

namespace Rmi.University.Questioning.Data
{
	public class QuestioningContext : DbContext
	{
		public QuestioningContext(DbContextOptions<QuestioningContext> options) : base(options)
		{

		}

		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Lecturer> Lecturers { get; set; }
	}
}
