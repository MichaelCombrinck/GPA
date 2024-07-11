using Microsoft.AspNetCore.Mvc;

namespace GPA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GPAController : ControllerBase
    {

        [HttpGet]
        public IActionResult Test()
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
            int totalGradePoints = course1Credit * course1Grade + course2Credit * course2Grade +
                                   course3Credit * course3Grade + course4Credit * course4Grade +
                                   course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;
            string formattedGPA = gradePointAverage.ToString("0.00");

            string response = $"Student: {studentName}\n\n";
            response += "Course\t\t\tGrade\tCredit Hours\n";
            response += $"{course1Name}\t\t{course1Grade}\t\t{course1Credit}\n";
            response += $"{course2Name}\t\t{course2Grade}\t\t{course2Credit}\n";
            response += $"{course3Name}\t\t{course3Grade}\t\t{course3Credit}\n";
            response += $"{course4Name}\t{course4Grade}\t\t{course4Credit}\n";
            response += $"{course5Name}\t\t{course5Grade}\t\t{course5Credit}\n";
            response += $"\nFinal GPA:\t\t{formattedGPA}";

            return Ok(response);
        }


       
    }
}
