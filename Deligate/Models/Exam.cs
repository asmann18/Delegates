namespace Deligate.Models;

public class Exam
{
    public string Subject { get; set; }
    public double ExamDuration { get; set; }
    public DateTime StartDate { get; init;}
    public DateTime EndDate { get; init;}

    public Exam(string subject,double examDuration)
    {
        Subject = subject;
        ExamDuration = examDuration;
        StartDate = DateTime.Now;
        EndDate = StartDate.AddHours(ExamDuration);
    }


    public override string ToString()
    {
        return $" subject: {Subject} ---- {ExamDuration} hour";
    }
}
