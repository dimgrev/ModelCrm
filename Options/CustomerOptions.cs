using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Options
{
    public class CustomerOptions
    {
		public string FirstName { get; set; }
		public string lastname { get; set; }
		public string address { get; set; }
		public string email { get; set; }
		public string vatnumber { get; set; }
		public string phone { get; set; }
		public DateTime Dob { get; set; }
	}
}
