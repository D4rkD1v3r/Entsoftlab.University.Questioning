using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entsoftlab.University.Questioning.Data.Models
{
	public class Group
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public uint StartYear { get; set; }
		public uint FinishYear { get; set; }
		public bool IsActive { get; set; }
		public TeachType TeachType { get; set; }
		public short Course { get; set; }


		public Guid FacultyId { get; set; }
		[ForeignKey("FacultyId")]
		public Faculty Faculty { get; set; }
	}
}
