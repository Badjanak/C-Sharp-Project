using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            //Input data
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            //Calculating price 1 lecture
            double honorar = budget / lectures;

            //Seting counters
            int countJelev = 0;
            int countRoYaL = 0;
            int countRoli = 0;
            int countTrofon = 0;
            int countSino = 0;
            int countOuterLecture = 0;

            //Seting Loop
            for (int name = 1; name <= lectures; name++)
            {
                string lectureName = Console.ReadLine();

                //Conditional statement
                switch (lectureName)
                {
                    case "Jelev":
                        countJelev++;
                        break;
                    case "RoYaL":
                        countRoYaL++;
                        break;
                    case "Roli":
                        countRoli++;
                        break;
                    case "Trofon":
                        countTrofon++;
                        break;
                    case "Sino":
                        countSino++;
                        break;

                    default:
                        countOuterLecture++;
                        break;
                }
            }

            //Calculating salaries
            double jelevSalary = countJelev * honorar;
            double roYaLSalary = countRoYaL * honorar;
            double roliSalary = countRoli * honorar;
            double trofonSalary = countTrofon * honorar;
            double sinoSalary = countSino * honorar;
            double outerLecture = countOuterLecture * honorar;

            //Printing results
            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", roYaLSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", outerLecture);
        }
    }
}
