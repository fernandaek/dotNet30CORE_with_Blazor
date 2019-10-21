using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_04
{
    public class Calculator
    {
        public double Add(double value1, double value2)
        {
            var result = value1 + value2;
            return result;
        }
         public double Add(double value1, double value2, out string output)
        {
            var result = Add(value1, value2);
            output = Output(value1, value2, result, '+');
            return result;
        }


        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        public double Subtract(double value1, double value2, out string output)
        {
            var result = Subtract(value1, value2);
            output = Output(value1, value2, result, '-');
            return result;
        }



        public double Devide(double value1, double value2)
        {
            return value1 / value2;
        }
        public double Devide(double value1, double value2, out string output)
        {
            var result = Devide(value1, value2);
            output = Output(value1, value2, result, '/');
            return result;
        }



        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        public double Multiply(double value1, double value2, out string output)
        {
            var result = Multiply(value1, value2);
            output = Output(value1, value2, result, 'x');
            return result;
        }




        private string Output(double value1, double value2, double result, char @operator)
        {
            return $"{value1}{@operator}{value2}= {result}";
        }
    }
}
