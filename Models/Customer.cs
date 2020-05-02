using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string lastname { get; set; }
		public string address { get; set; }
		public string email { get; set; }
		public string vatnumber { get; set; }
		public string phone { get; set; }
		public decimal TotalGross { get; set; }
		public bool IsActive { get; set; }
		public DateTime Dob { get; set; }
		public DateTime CreatedDate { get; set; }
		public List<Order> Orders { get; set; }

	}
}
