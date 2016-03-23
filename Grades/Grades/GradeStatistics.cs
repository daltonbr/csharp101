using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        // constructor
        public GradeStatistics()
        {
            this.HighestGrade = 0;
            this.LowestGrade = float.MaxValue;
        }

        // variables
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
