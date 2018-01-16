using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entsoftlab.University.Questioning.Data.Models {
	/// <summary>
	/// Факультет.
	/// </summary>
	public class Faculty {
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
		/// Фамилия И.О.  декана.
		/// </summary>
		public string DeanFullName { get; set; }

		public List<Group> Groups { get; set; }
	}
}
