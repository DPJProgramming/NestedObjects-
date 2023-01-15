using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects {

	/// <summary>
	/// Represents an individual college advisor
	/// </summary>
	public class Advisor {

		/// <summary>
		/// Advisor's legal first and last name
		/// </summary>
		public string FullName {get; set;}

		/// <summary>
		/// advisor's school email
		/// </summary>
		public string Email { get; set;}

		/// <summary>
		/// location of advisors office (building and room number)
		/// </summary>
		public string OfficeLocation { get; set;}
	}
}
