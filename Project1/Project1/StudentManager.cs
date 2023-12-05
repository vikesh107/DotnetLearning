using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class StudentManager
    {

        private List<Student> students = new List<Student>();
        private static object lockObject = new object();

        // Add student to the system
        public void AddStudent(Student student)
        {
            lock (lockObject)
            {
                students.Add(student);
            }
        }

        // Get all students
        public List<Student> GetAllStudents()
        {
            lock (lockObject)
            {
                return students.ToList();
            }
        }

        // Filter students
        public List<Student> FilterStudents(StudentFilter filter)
        {
            lock (lockObject)
            {
                return students.Where(filter).ToList();
            }
        }

        // Other methods for additional tasks...

        // Method to run every 10 seconds
        public void RunEvery10Seconds()
        {
            while (true)
            {
                Thread.Sleep(10000);
                // Implement logic to find all classes where students belong to
                Console.WriteLine("Checking classes every 10 seconds...");
            }
        }
    }
}
