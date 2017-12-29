using System;

namespace CSharp7Refs
{
    class Program
    {
        static void Main(string[] args)
        {
            RefReturns refReturns = new RefReturns();

            ref int grade = ref refReturns.DoStuff();

            grade = 17;

            refReturns.PrintGrade();


            RefLocals.PrintPoints();
        }
    }
}
