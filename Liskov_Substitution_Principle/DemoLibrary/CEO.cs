using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class CEO : BaseEmployee,IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("CEO review");
        }

    }
}
