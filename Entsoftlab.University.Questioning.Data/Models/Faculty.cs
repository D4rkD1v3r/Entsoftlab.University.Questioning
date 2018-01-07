using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entsoftlab.University.Questioning.Data.Models
{
	public class Faculty
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string FullName { get; set; }
		public string DeanFullName { get; set; }

		public List<Group> Groups { get; set; }
	}
}
