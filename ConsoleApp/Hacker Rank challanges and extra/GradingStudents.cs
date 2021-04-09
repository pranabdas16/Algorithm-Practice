using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Hacker_Rank_challanges_and_extra
{
    /// <summary>
    /// Grading Students
    /// https://www.hackerrank.com/challenges/grading/problem
    /// GradingStudents objGS = new GradingStudents();
    /// objGS.gradingStudents();
    /// </summary>
    class GradingStudents
    {
        public void gradingStudents()
        {
            List<int> grades = new List<int>();
            grades.Add(73);
            grades.Add(67);
            grades.Add(38);
            grades.Add(33);

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] > 40)
                {
                    int val = grades[i] % 10;
                    if (val == 3 || val == 8)
                    {
                        grades[i] += 2;
                    }
                    if (val == 4 || val == 9)
                    {
                        grades[i] += 1;
                    }
                    else
                    {
                        grades[i] = grades[i];
                    }
                }
            }

            foreach (int t in grades)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }
    }
}
