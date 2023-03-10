using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentInfo
{
    public int StudentID { get; set; }
    public List<Subjects> Marks { get; set; } = new List<Subjects>();
    public bool isPass()
    {
        foreach (var Bool in Marks)
        {
            if (Bool.FinalScore <= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
class Subjects
{
    public int SubjectID { get; set; }
    public string Subject { get; set; }
    public float FirstTermScore { get; set; }
    public float SecondTermScore { get; set; }
    public float ThirdTermScore { get; set; }
    public float FinalScore()
    {
        return FirstTermScore + SecondTermScore + ThirdTermScore;
    }
}
class Functions
{
    static void Main(string[] args)
    {
        List<StudentInfo> ReportCard = new List<StudentInfo>()
  

  }
}