using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects {

	/// <summary>
	/// represents an individual college student
	/// </summary>
	public class Student {

		/// <summary>
		/// Student's legal first name
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Student's legal last name
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// student's school email address
		/// </summary>
		public string SchoolEmail { get; set; }

		/// <summary>
		/// Student's date of birth (excluding time)
		/// </summary>
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		/// Student's primary phone number
		/// </summary>
		public int PhoneNumber { get; set; }

		public Advisor AssignedAdvisor { get; set; } 
	}
}
