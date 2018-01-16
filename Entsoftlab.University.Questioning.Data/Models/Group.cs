using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entsoftlab.University.Questioning.Data.Models {
	/// <summary>
	/// Учебная группа.
	/// </summary>
	public class Group {
		/// <summary>
		/// Уникальный идентификатор.
		/// </summary>
		[Key]
		public Guid Id { get; set; }
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Год начала обучения.
		/// </summary>
		public uint StartYear { get; set; }
		/// <summary>
		/// Год окончания обучения.
		/// </summary>
		public uint FinishYear { get; set; }
		/// <summary>
		/// Статус группы.
		/// </summary>
		public bool IsActive { get; set; }
		/// <summary>
		/// Форма обучения.
		/// </summary>
		public TeachType TeachType { get; set; }
		/// <summary>
		/// Текущий курс.
		/// </summary>
		public short Course { get; set; }


		public Guid FacultyId { get; set; }
		[ForeignKey("FacultyId")]
		public Faculty Faculty { get; set; }
	}
}
