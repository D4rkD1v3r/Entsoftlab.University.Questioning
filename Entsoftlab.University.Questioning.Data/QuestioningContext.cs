using Entsoftlab.University.Questioning.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Entsoftlab.University.Questioning.Data
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
