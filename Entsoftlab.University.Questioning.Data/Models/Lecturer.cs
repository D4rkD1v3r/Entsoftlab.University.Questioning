using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entsoftlab.University.Questioning.Data.Models
{
    public class Lecturer
    {
			[Key]
			public Guid Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public string FathersName { get; set; }
			public string Degree { get; set; }
			public LecturerState State { get; set; }

			public Guid DepartmentId { get; set; }
			[ForeignKey("DepartmentId")]
			public Department Department { get; set; }
    }
}
