using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entsoftlab.University.Questioning.Data.Models {
	/// <summary>
	/// Кафедра.
	/// </summary>
	public class Department {
		/// <summary>
		/// Уникальный идентификатор.
		/// </summary>
		[Key]
		public Guid Id { get; set; }
		/// <summary>
		/// Краткое наименование.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Полное наименование.
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Фамилия И.О. заведующего.
		/// </summary>
		public string MainFullName { get; set; }

		public List<Lecturer> Lecturers { get; set; }
	}
}
