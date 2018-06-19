using System;

namespace hw14
{
    class program
    {
        public void Homework() {
            Console.WriteLine("this is homework four-teen!");
            
        }

        private void Classwork() {
            Console.WriteLine("our classwork is an app project");
            
        }

        public int Lessons() {
            int returnVariable = 1 + 12;
            return returnVariable;
        }

        public void Grade(int _5, string _basic) {
            Console.WriteLine("{0} is my midterm grade", _5);
            Console.WriteLine("{0} is my effort", _basic);
            Console.ReadKey();
        }
    }
}
