using System;

namespace CSharp7Refs
{
    public class RefReturns
    {
        public RefReturns()
        {
            this._grade = 2;
        }

        private int _grade;

        public void PrintGrade()
        {
            Console.WriteLine($"Grade: {this._grade}");
        }

        public ref int DoStuff()
        {
            return ref this._grade;
        }
    }
}
