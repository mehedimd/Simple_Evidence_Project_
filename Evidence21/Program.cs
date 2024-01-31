using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence21
{
    internal class Program
    {
        static void Main()
        {
            // Ans: (a) Example of checked and unchecked Expression
            try
            {
                int number = int.MaxValue;
                // checked
                checked
                {
                    int willThrow = number++;
                    Console.WriteLine("This will not be reached");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // unchecked
            int number2 = int.MaxValue;
            unchecked
            {
                Console.WriteLine($"Number:{number2}");
                int wontThrow = number2++;
                Console.WriteLine($"Unchecked Number++ : {wontThrow}\nThis will be reached");

            }

            // Ans: (b) Return multiple value example
            
            (int,string,string) Student(int id, string name)
            {
                
                string project = "IDB-BISEW IT Scholarship Project"; // Ans: (c) This is a Local variable of Student Method this is also called a Block
                                                                     // Scope Variable Because we can't use this variable outside of this method.
                id = ++id;
                name = "Md." + name;

                return (id, name, project);
            }
            int sId = 0; string sName = "Mehedi Hasan"; // Ans: (c) These are Global variable of Program Class we use it anywhere in class
            (int studentId, string studentName, string projectName) = Student(sId,sName);

            Console.WriteLine($"Your ID is: {studentId}, Your Name is: {studentName}, Your Project Name is: {projectName}");

            Console.ReadKey();
        }
    }
}
