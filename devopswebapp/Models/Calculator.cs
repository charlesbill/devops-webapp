using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devopswebapp.Models
{
    public class Calculator
    {
        [Display( Name = "First Value" )]
        public double NumberA { get; set; }

        [Display( Name = "Second Value" )]
        public double NumberB { get; set; }

        [Display( Name = "Total" )]
        public double Total { get; set; }
    }

    public class Calculation
    {
        Calculator calcModel;
        public Calculation()
        {
            calcModel = new Calculator();
        }

        public double AddTwoValues(double valOne, double valTwo)
        {
            return valOne + valTwo;
        }
    }
}