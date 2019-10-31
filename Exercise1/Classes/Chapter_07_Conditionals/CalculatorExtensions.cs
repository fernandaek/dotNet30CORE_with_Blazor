using Exercise1.Classes.Chapter_07_Conditionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes
{
    public static class CalculatorExtensions
    {
        public static Operation ChangeOperator(this Operation result, Operators @operators) => result.SetOperator(@operators);
        public static Operation ChangeValue(this Operation result, double value) => result.SetValue(value);
        public static Operation Calculate(this Operation result, Operation operation) => result.Operator switch
        {


            //{
            //    switch (result.Operator)
            //    {
            //        case Operators.Add:
            //            result.SetValue(result.Value + operation.Value);
            //            break;
            //        case Operators.Subtract:
            //            result.SetValue(result.Value - operation.Value);
            //            break;
            //        case Operators.Devide:
            //            result.SetValue(result.Value / operation.Value);
            //            break;
            //        case Operators.Multiply:
            //            result.SetValue(result.Value * operation.Value);
            //            break;
            //        case Operators.Equal: return result;

            //        default: throw new ArgumentException("Opertion does not exist.", nameof(operation));

            //    }
            //    return result.SetOperator(operation.Operator);
            //}

            Operators.Add =>
            result.ChangeValue(result.Value + operation.Value).ChangeOperator(operation.Operator),

            Operators.Subtract =>
            result.ChangeValue(result.Value - operation.Value).ChangeOperator(operation.Operator),
            
            Operators.Devide =>
            result.ChangeValue(result.Value / operation.Value).ChangeOperator(operation.Operator),

            Operators.Multiply =>
            result.ChangeValue(result.Value * operation.Value).ChangeOperator(operation.Operator),

            Operators.Equal => result,
            _ => throw new ArgumentException("Opertion does not exist.", nameof(operation))
        };
    }
}
