using System;

namespace StaticFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //加
            var operationAdd = OperationFactory.CreateOperation(OperationEnum.Add);
            operationAdd.Num1 = 10;
            operationAdd.Num2 = 20;
            Console.WriteLine(operationAdd.Calc());

            //减
            var operationSubtract = OperationFactory.CreateOperation(OperationEnum.Subtract);
            operationSubtract.Num1 = 10;
            operationSubtract.Num2 = 20;
            Console.WriteLine(operationSubtract.Calc());


            //乘
            var operationMultiply = OperationFactory.CreateOperation(OperationEnum.Multuply);
            operationMultiply.Num1 = 10;
            operationMultiply.Num2 = 20;
            Console.WriteLine(operationMultiply.Calc());

            //除
            var operationDivide = OperationFactory.CreateOperation(OperationEnum.Divide);
            operationDivide.Num1 = 10;
            operationDivide.Num2 = 20;
            Console.WriteLine(operationDivide.Calc());
            Console.ReadKey();
        }
    }
}
