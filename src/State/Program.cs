using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();

            work.Hour = 10;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();

            work.Hour = 13;
            work.WriteProgram();

            work.Hour = 14;
            work.WriteProgram();

            work.Hour = 17;

            work.TaskFinished = true;
            //work.TaskFinished = false;
            work.WriteProgram();

            work.Hour = 19;
            work.WriteProgram();


            work.Hour = 22;
            work.WriteProgram();


            Console.Read();
        }
    }
}