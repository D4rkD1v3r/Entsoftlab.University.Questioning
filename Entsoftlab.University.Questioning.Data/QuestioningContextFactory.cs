using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Entsoftlab.University.Questioning.Data {
	/// <summary>
	/// Фабрика контекста базы данных.
	/// </summary>
	public class QuestioningContextFactory : IDesignTimeDbContextFactory<QuestioningContext> {
		/// <summary>
		/// Создание контекста базы данных.
		/// </summary>
		/// <param name="args">Дополнительные параметры.</param>
		/// <returns>Контекст базы данных. <seealso cref="QuestioningContext"/></returns>
		public QuestioningContext CreateDbContext(string[] args) {
			var optionsBuilder = new DbContextOptionsBuilder<QuestioningContext>();
			optionsBuilder.UseNpgsql("User ID=questioning;Password=P@ssw0rd;Host=localhost;Port=5432;Database=questioningdb;Pooling=true;");

			return new QuestioningContext(optionsBuilder.Options);
		}
	}
}
