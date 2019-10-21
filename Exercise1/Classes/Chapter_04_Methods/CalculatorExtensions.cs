using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_04_Methods
{
    public static class CalculatorExtensions
    {
        public static Values Add(this Values values)
        {
            values.Result = values.Value1 + values.Value2;
            values.Operator = Operators.Add;
            return values;
        }

        public static Values Subtract(this Values values)
        {
            values.Result = values.Value1 - values.Value2;
            values.Operator = Operators.Subtract;
            return values;
        }

        public static Values Devide(this Values values)
        {
            values.Result = values.Value1 / values.Value2;
            values.Operator = Operators.Devide;
            return values;
        }

        public static Values Multiply(this Values values)
        {
            values.Result = values.Value1 * values.Value2;
            values.Operator = Operators.Multiply;
            return values;
        }


        public static string Output(this Values values)
        {
            return $"{values.Value1}{(char)values.Operator}{values.Value2} = {values.Result}";
        }
    }
}
