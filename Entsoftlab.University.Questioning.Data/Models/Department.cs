using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entsoftlab.University.Questioning.Data.Models
{
	public class Department
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string FullName { get; set; }
		public string MainFullName { get; set; }

		public List<Lecturer> Lecturers { get; set; }
	}
}
