using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entsoftlab.University.Questioning.Data.Models {
	/// <summary>
	/// Преподаватель.
	/// </summary>
	public class Lecturer {
		/// <summary>
		/// Уникальный идентификатор.
		/// </summary>
		[Key]
		public Guid Id { get; set; }
		/// <summary>
		/// Имя.
		/// </summary>
		public string FirstName { get; set; }
		/// <summary>
		/// Фамилия.
		/// </summary>
		public string LastName { get; set; }
		/// <summary>
		/// Отчество.
		/// </summary>
		public string FathersName { get; set; }
		/// <summary>
		/// Ученая степень.
		/// </summary>
		public string Degree { get; set; }
		/// <summary>
		/// Статус преподавателя.
		/// </summary>
		public LecturerState State { get; set; }

		public Guid DepartmentId { get; set; }
		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }
	}
}
