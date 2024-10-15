using System.Reflection.Metadata;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.models
{
    public class Marks
    {
        public List<int> marks = new List<int>();
        public int AddedMarks = 0, SumOfMarks;

        public void AddMarks()
        {
            Console.Write($"How Many Marks Do You Want to Add? :: ");
            int numberOfMarksToAdd = int.Parse(Console.ReadLine());
            Console.WriteLine($"-------------Adding Marks--------------");
            int n = 0;
            while(n < numberOfMarksToAdd)
            {
                Console.Write($"Enter Mark {n + 1}: ");
                marks.Add(int.Parse(Console.ReadLine()));
                n++;
            }
            Console.WriteLine($"------------------------");
            Console.WriteLine($"Marks Added Succesfully!");

            AddedMarks = marks.Count();
        }
        public void RemoveMarks()
        {
            Console.Write($"How Many Marks Do You Want to Remove? :: ");
            int numberOfMarksToRemove = int.Parse(Console.ReadLine());
            Console.WriteLine($"-------------Removing Marks--------------");
            int n = 0;
            while(n < numberOfMarksToRemove)
            {
                Console.Write($"Enter Mark {n + 1}: ");
                int markToRemove = int.Parse(Console.ReadLine());

                if(marks.Contains(markToRemove))
                {
                    marks.Remove(markToRemove);
                    Console.WriteLine($"Success Messege: Mark Removed");
                    n++;
                }
                else
                {
                    Console.WriteLine($"Error Messege: Given Marks Does not Esixts!");
                    break;
                }
            }
            
        }
        public void IsMarkExists()
        {
            Console.WriteLine($"-----------------");
            Console.Write($"Search a Mark: ");
            int mark = int.Parse(Console.ReadLine());

            bool isExists = marks.Contains(mark);

            Console.WriteLine($"Is Mark Exist? -> {isExists}");
            
        }
        private int SumOfAllMarks()
        {
            SumOfMarks = 0;

            if(marks.Count() > 0)
            {
                foreach(int mark in marks)
                {
                    SumOfMarks += mark;
                }
                return SumOfMarks;
            }
            else
            {
               return 0;
            }
        }
        public void TotalMarks()
        {
            if(SumOfAllMarks() != 0)
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Total Marks: {SumOfAllMarks()}");
            }
            else
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Error Messege: Empty or Low Marks Exists!");
            }
        }
        public void TotalMarksNumber()
        {
            Console.WriteLine($"-------------------");
            Console.WriteLine($"The Mark You Added: {AddedMarks}");
        }
    }
}