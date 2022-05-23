using System;

namespace Z_2
{
    class Trial
    {
        public int grade;
        public string name;
        public void Print()
        {
            Console.WriteLine(name);
        }
    }
    class   FinalExam: Trial
    {
        public string thing;
    }
    class Exam: FinalExam
    {
        public int numberOfSemester;
    }
    class Test: Exam
    {
        public int numberOfQuestions;
    }

    class Program
    {
        static void Main(string[] args)
        {
            FinalExam mathematics = new FinalExam();
            Console.WriteLine("Введите название выпускного экзамена:");
            mathematics.name = Console.ReadLine();
            mathematics.Print();
        }
    }
}
