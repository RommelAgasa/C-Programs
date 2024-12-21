using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet04___Agasa
{
    internal class Employee
    {

        // Class fields
        public string ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Rate { get; set; }
        private decimal GrossPay;

        // Method for Computing Gross Pay
        public void ComputeGrossPay(double dblhourseWorked)
        {
            // Compute weekly pay before taxes
            if(dblhourseWorked <= 40)
                GrossPay = Convert.ToDecimal(dblhourseWorked) * Rate;
            else 
                GrossPay = 40 * Rate + (Convert.ToDecimal(dblhourseWorked) 
                    - 40M) * 1.5M * Rate;
        }

        // Method for getting Gross Pay
        public decimal GetGrossPay()
        {
            return GrossPay;
        }

    }
}
