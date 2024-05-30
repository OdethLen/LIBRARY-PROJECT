using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LIBRARY_PROJECT
{
	internal class Book:Register
	{
		//properties
		protected string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}



		protected string author;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		protected string publisher;

		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}

        private DateTime enddate;

        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        //Constructor
        public Book():base()
		{
			title = "";
			author = "";
			publisher = "";
			Enddate = DateTime.Now;
		}

		public Book(string name, string title, string author, string publisher, DateTime date, DateTime enddate) : base(name, date )
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.Enddate = enddate;
        }

        // Metodo Sin parametros de entrada y con retorno de datos 
        public override string ToString()
        {
			return "Name: " + name + "Date: "+ date +"End date: "+ Enddate + "Title: " + title + "Author: " + author + "Publisher: " + publisher;
        }

    }
}
