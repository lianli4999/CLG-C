using System;
using System.Collections.Generic;

namespace CourseCoordinator
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello World!");
			// Create list of students
            
			var students = new List<string>{"Joy", "Marta", "Yuko", "Anjen"};
			// Create list of courses at the university
			var courses = new List<string>{"Chemistry", "Fashion Design", "Philosophy", "Medicine"};
			// student enrollments
            var joyCourses = new List<string>{"Fashion Design","Medicine"};
            var martaCourses = new List<string>{"Chemistry", "Philosophy"};
            var yukoCourses = new List<string>{"Chemistry", "Philosophy", "Medicine"};
            var anjenCourses = new List<string>{"Chemistry"};

            while (true)
			{
				Console.WriteLine("What would you like to see or do? Please enter a number");
				// list what options the user can enter
				Console.WriteLine("1: Students = See a list of students at the university");
				Console.WriteLine("2: Courses = See a list of courses at the university");
				Console.WriteLine("3: Enrol = Enrol a new student at the university");
				Console.WriteLine("4: Unenrol = Unenrol a student");
				Console.WriteLine("5: AddCourse = Add a new course to the university catalogue");
				Console.WriteLine("6: RemoveCourse = Remove a course from the university catalogue");
                Console.WriteLine("7: List the courses each student is enrolled in")
				Console.WriteLine("X = Exit");
				var userInput = int.Parse(Console.ReadLine());

                // check .ToUpper 

				// exit the code if a user inputs X
				if (userInput == "X")
				{
					break;
				}


				// respond to the user command
				switch (userInput)
				{
					case 1:
						Console.WriteLine("Here is a list of students:");
						// code to list all students at uni
                        for(var i=0; i<students.Count; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
						break;
					case 2:
						Console.WriteLine("Here is a list of courses offered:");
						// code to list all courses on offer
                         for(var i=0; i<courses.Count; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
						break;
                    case 3:
                        // enrol more students to the university
                        Console.WriteLine("List the student(s) to be enrolled (case sensitive)");
                        var student = string.Parse(Console.ReadLine());
                        students.Add(student);
                        break;
                    case 4:
                        // unenrol students from uni
                        Console.WriteLine("List the student(s) to be unenrolled (case sensitive)");
                        var student = string.Parse(Console.ReadLine());
                        students.Remove(student);
                        break;
                    case 5:
                        // add a new course to uni catalogue
                        Console.WriteLine("List the course to be added (case sensitive)");
                        var course = string.Parse(Console.ReadLine());
                        courses.Add(course);
                        break;
                    case 6:
                        // remove a course from uni catalogue
                        Console.WriteLine("List the course to be removed (case sensitive)");
                        var course = string.Parse(Console.ReadLine());
                        courses.Remove(course);
                        break;
                    case 7:
                        // list the courses each student is enrolled in
                        Console.WriteLine("Choose a student to display their enrollments. (input lower case names only)");
                        var studentName = string.Parse(Console.ReadLine());
                        foreach (var course in studentName+Courses)
                        {
                            Console.WriteLine(studentName+Courses);
                        }
                        break;
					default:
						Console.WriteLine("I didn't recognise that command, please select another option");
						break;
				}
			}
		}
	}
}

