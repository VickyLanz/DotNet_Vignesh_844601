using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 67, 68, 69, 70, 72, 73 };
            IResult R = new IResult();
            var avg = R.GetAverageMarks(marks);
            R.DisplayAverage(avg);
            R.ShowGrade(avg);
        }
    }
    public interface IExam
    {
         double GetAverageMarks(int[] marks);
         void DisplayAverage(double avg);
    }
    public interface IStudent
    {
        void ShowGrade(double avg);
    }
    public class IResult : IExam,IStudent
    {
        public double GetAverageMarks(int[] marks)
        {
            double total=0;
            double a;
            for (int i = 0; i < marks.Length; i++)
                total+= marks[i];
            a = total/ marks.Length;
            return a;
        }
        public void DisplayAverage(double avg)
        {
            Console.WriteLine("{0}", avg);
        }
        public void ShowGrade(double avg)
        {
            if (avg >= 70.00)
                Console.WriteLine("Distinction");
            else
                Console.WriteLine("Not a Distinction");
        }
    }
}
