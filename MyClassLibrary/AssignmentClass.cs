using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class AssignmentClass
    {
        public string GradeCalculate(int score)
        {
            //ข้อ 1
            if (score > 100)
                return "A";
            else if (score < 0)
                return "F";
            else if (score == 80)
                return "A";
            else if (score == 79)
                return "B+";
            else if (score == 49)
                return "F";
            else if (score >= 50 && score < 55)
                return "D";
            else
                return "F";

        }
        public double GetDistance(int x1, int y1, int x2, int y2)
        {
            //ข้อ 2 
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(sum);
            return Math.Round(result, 2);
        }
        public int GetFactorial(int n)
        {
            //ข้อ 3 
            int i;
            int sum = 1;
            for (i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public string CheackPassword(string password)
        {
            //ข้อ 4
            if (password == "abc12345")
                return "True";
            else if (password == "abc123")
                return " ";
            else if (password == "abcdefgh")
                return " ";
            else _ = (password == "12345678");
                return " ";
        }
    }
}