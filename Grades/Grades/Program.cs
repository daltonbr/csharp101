using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is the grade book program");


            GradeBook book = new GradeBook();
            //book.Name("Dalton's Grade Book");
            book.Name = "Teste book";
            book.Name = null;  // this line will be invalidate
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine("Average: " + stats.AverageGrade);
            WriteResult("Average", stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            //                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Console.WriteLine(stats.LowestGrade);
            WriteResult("Lowest", (int)stats.LowestGrade);

            Console.ReadKey();
        }
      static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":" + result);
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine(description + ":" + result);
            Console.WriteLine($"{description}: {result}");  // same result as above
        }
    }
}



