using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public String Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value) )
                {
                   this._name = value;
                }
            }
        }

        public String Name;
        public static float MinimumGrade = 0;
        public static float MaximumGrade = 100;
        List<float> grades = new List<float>();
        
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            
            //average grade
            float sum = 0;
            foreach(float grade in grades)
            {
                sum += grade;
                
                //if ( grade > stats.HighestGrade )
                //{
                //    stats.HighestGrade = grade;
                //}

                //if (grade < stats.LowestGrade)
                //{
                //    stats.LowestGrade = grade;
                //}

                // this two lines are equivalent to the 2 IF's above - so elegant =)
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);               
            }
            stats.AverageGrade = sum / grades.Count; // beware the division by zero when grades has zero elements

            return stats;
        } 


    public void AddGrade(float _grade)
        {
            grades.Add(_grade);
           
        }
        

    }
}
