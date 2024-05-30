using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_PROJECT
{
    internal class Register
    {
		protected string name;
	
        public string Name
		{
			get { return name; }
			set { name = value; }
		}


		protected DateTime date;

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		//Constructor

		public Register ()
		{
			name = "";
			date = DateTime.Now;
		}

		public Register(string name, DateTime date)
		{
			this.name = name;
			this.date = date;
		}

		//Method
		public override string ToString() 
		{
			return "Name: "+ name +"Date: " + date ;
		}

	}
}
