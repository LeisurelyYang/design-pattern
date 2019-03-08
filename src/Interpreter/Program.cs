using System;
using System.Text;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PlayContext context = new PlayContext();

            Console.WriteLine("霸王别姬:");

            context.PlayText = "O 2 E 0.5 A 3 E 0.5 ";

            Expression expression = null;

            try
            {
                while (context.PlayText.Length > 0)
            {
                string str = context.PlayText.Substring(0, 1);

                switch (str)
                {
                    case "O":
                        expression = new Scale();
                        break;
                    case "C":
                    case "D":
                    case "E":
                    case "F":
                    case "G":
                    case "A":
                    case "B":
                    case "P":
                        expression = new Note();
                        break;
                }

                expression.Interpret(context);
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}