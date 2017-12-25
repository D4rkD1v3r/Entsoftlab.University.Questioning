using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rmi.University.Questioning.Data.Models
{
	public class Group
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int StartYear { get; set; }
		public int FinishYear { get; set; }
		public bool IsActive { get; set; }
		public short TeachType { get; set; }
		public short Course { get; set; }


		public Guid FacultyId { get; set; }
		[ForeignKey("FacultyId")]
		public Faculty Faculty { get; set; }
	}
}
