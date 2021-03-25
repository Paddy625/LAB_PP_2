using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LAB_PP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"students.json");
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

            foreach (var s in students)
            {
                Console.WriteLine(s.studentId + ":\t" + s.studentName);
            }
        }

    }

    class Student
    { 
        public int studentId { set; get; }
        public string studentName { set; get; }
    }
}
