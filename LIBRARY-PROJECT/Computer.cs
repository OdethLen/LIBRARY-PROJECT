using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY_PROJECT
{
    internal class Computer : Register
    {
        protected string computernumber;

        public string Computernumber
        {
            get { return computernumber; }
            set { computernumber = value; }
        }

        //Propiedad de solo lectura 
        protected double cost = 0.26;

        public double Cost
        {
            get { return cost; }
        }

        private int printnumber;

        public int Print_number
        {
            get { return printnumber; }
            set { printnumber = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        //Constructor

        public Computer() : base()
        {
            computernumber = "";
            cost = 0.26;
            total = 0;
        }

        public Computer(string name, DateTime date, string computernumber, int printnumber ) : base(name, date)
		{
			this.computernumber = computernumber;
            this.printnumber = printnumber;
            
            
		}

        public override string ToString() 
        {
            return"Name: "+ name + "Date: " + date + "Computer number: " + computernumber;
        }

        //metodo con paramentros  y regreso de datos
        public double Gettotal(double cost, int printnumber)
        {
            double total = cost * printnumber;
            return total;
        }

        
    }
}
