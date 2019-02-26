using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperation(OperationEnum operType)
        {
            Operation oper = null;
            switch (operType)
            {
                case OperationEnum.Add:
                    oper = new AddOperation();
                    break;
                case OperationEnum.Subtract:
                    oper = new SubtractOperation();
                    break;
                case OperationEnum.Multuply:
                    oper = new MultiplyOperation();
                    break;
                case OperationEnum.Divide:
                    oper = new DivideOperation();
                    break;
            }
            return oper;
        }
    }
}
