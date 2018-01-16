using Entsoftlab.University.Questioning.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Entsoftlab.University.Questioning.Data {
	/// <summary>
	/// Контекст базы данных.
	/// </summary>
	public class QuestioningContext : DbContext {
		public QuestioningContext(DbContextOptions<QuestioningContext> options) : base(options) {
		}
		/// <summary>
		/// Факультеты.
		/// </summary>
		public DbSet<Faculty> Faculties { get; set; }
		/// <summary>
		/// Кафедры.
		/// </summary>
		public DbSet<Department> Departments { get; set; }
		/// <summary>
		/// Группы.
		/// </summary>
		public DbSet<Group> Groups { get; set; }
		/// <summary>
		/// Преподаватели.
		/// </summary>
		public DbSet<Lecturer> Lecturers { get; set; }
	}
}
