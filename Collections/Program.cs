using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Collections.models;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implement Add, Remove, Count and Contains Methods in a single class
            Marks Rahim = new Marks();
            Rahim.AddMarks();
            Rahim.RemoveMarks();
            Rahim.IsMarkExists();
            Rahim.TotalMarks();
            Rahim.TotalMarksNumber();


            //Complex Type Lists
            Student shofiq = new Student();
            shofiq.StudentID = "#4";
            shofiq.Name = "Shofiq The Ganstar";
            shofiq.Age = 4;
            shofiq.Email = "gangstershofiq@gmail.com";

            Student joy = new Student()
            {
                StudentID = "#5",
                Name = "Joy",
                Age = 5,
                Email = "joy@gmail.com"
            };

            List<Student> students = new List<Student>()
            {
                //Way Of Adding - 1
                new Student
                {
                    StudentID = "#1",
                    Name = "Rahim",
                    Age = 15,
                    Email = "rahim@gmail.com"
                },
                new Student
                {
                    StudentID = "#2",
                    Name = "Karim",
                    Age = 17,
                    Email = "karim@gmail.com"
                }
            };
            //Way Of Adding - 2
            students.Add(new Student {StudentID = "#3", Name = "Jobbar", Age = 43, Email = "jobbar@gmail.com"});
            //way of Adding -3 
            students.Add(shofiq);
            students.Add(joy);

            //Print All Students
            foreach(Student objects in students){
                Console.WriteLine($"Student ID: {objects.StudentID}");
                Console.WriteLine($"Name: {objects.Name}");
                Console.WriteLine($"Age: {objects.Age}");
                Console.WriteLine($"Email: {objects.Email}");
                Console.WriteLine($"--------------");
            }
            //Print Students Name on Certain Condition
            Console.WriteLine($"All the Students Name who are Above 5");
            Console.WriteLine($"----------------------");
            foreach(Student objects in students){
                if(objects.Age > 5)
                {
                    Console.WriteLine($"Name: {objects.Name}");
                }
            }
        }
    }
}