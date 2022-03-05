// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
/*In this task we’ll set up a system that can manage student exams 
and grade allocations. The system will manage how markers enter student
exam results into the system, whilst keeping the students’ names private 
to reduce the possibility of bias during the exam marking process. */



namespace ExamCentre
{
    class Program

    {
        static void Main(string[] args)
        {
            var exam = new Exam("Bioinformatics");

            var student1 = new Student("Ama", 3314);

            var student2 = new Student("Jess", 3315);

            exam.AddStudent(student1);

            exam.AddStudent(student2);


            Console.WriteLine($"{student2.StudentName}, student number protected, has an exam in {exam.Subject}");

            Console.WriteLine("The students and their scores are: (only revealed if using PrintStudent())");
            exam.ListStudents(student1);

        }

        public class Student
        {
            private int StudentNo;
            private int StudentScore;
            private List<int> StudentScores;
            public string StudentName;

            public Student(string studentName, int studentNo)
            {
                StudentName = studentName;
                StudentNo = studentNo;
            }

            public void AddScore(int studentScore)
            {
                StudentScore = studentScore;
                StudentScores.Add(studentScore);
            }

            public void MarkPaper(int studentNo, int studentScore, List<Student> Students)
            {
                var student = Students.Find(x => x.StudentNo == studentNo);
                student?.AddScore(studentScore);
            }

            public void PrintStudent() //have to have this method in student class to allow ListStudents to call it
            {
                Console.WriteLine($"Student Name: {StudentName}, Student Number: {StudentNo}, Student Score: {StudentScore}");
            }


        }



        public class Exam
        {
            public string Subject;
            internal List<Student> Students { get; set; }

            public Exam(string subject)
            {
                Subject = subject;
                //Student initialCase = new Student("Amy", 213);
                Students = new List<Student> { };

            }

            public void AddStudent(Student student)
            {
                Students.Add(student);
            }

            public void ListStudents(Student student)
            {
                foreach (var Student in Students)
                {
                    Student.PrintStudent();
                }
            }

        }
    }
}

