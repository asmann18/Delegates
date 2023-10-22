using Deligate.Models;

namespace Deligate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person1 = new("Asiman", "Qasimov", 21);
            Person person2 = new("Zulfiyye", "Qurbanova", 19);
            Person person3 = new("Sabuhi", "Camalzada", 20);
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            Predicate<Person> FindAllByName = (person) => person.Name == "Asiman";
            Predicate<Person> FindAllBySurname = (person) => person.Surname.EndsWith("ov") || person.Surname.EndsWith("ova");
            Predicate<Person> FindAllByAge = (person) => person.Age>20;


            //FindAll(people, FindAllByName);
            //Console.WriteLine();
            //FindAll(people, FindAllBySurname);
            //Console.WriteLine();
            //FindAll(people, FindAllByAge);



            List<Exam> exams = new List<Exam>();
            Exam exam1 = new("salam", 3);
            Exam exam2 = new("salam1", 1);
            Exam exam3 = new("salam2", 2.4);
            Exam exam4 = new("salam3", 0.000001);

            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);
            exams.Add(exam4);

            Predicate<Exam> filterByDate = (e) => e.StartDate.AddDays(7)>DateTime.Now ;
            Predicate<Exam> filterByDuration = (e) => e.ExamDuration > 2;
            Predicate<Exam> filterByOnlineExam = (e) => e.EndDate > DateTime.Now;

            FilterExams(exams, filterByDate);
            Console.WriteLine();
            FilterExams(exams,filterByDuration);
            Console.WriteLine();
            FilterExams(exams, filterByOnlineExam);
        }


        public static void FilterExams(List<Exam> exams,Predicate<Exam> func)
        {
            foreach (Exam exam in exams)
            {
                if (func(exam))
                {
                    Console.WriteLine(exam);
                }
            }
        }


        public static void FindAll(List<Person> people,Predicate<Person> func)
        {
            foreach (Person value in people)
            {
                if (func(value))
                {
                    Console.WriteLine(value);
                }
            }
        } 

    }
}