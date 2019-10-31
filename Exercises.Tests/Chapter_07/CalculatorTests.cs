using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercise1.Classes.Chapter_07_Conditionals;
using Exercise1.Classes;

namespace Exercises.Tests.Chapter_07
{
    public class CalculatorTests
    {
        [Fact]
        public void CanCreateOperationInstance()
        {
            Operation operation = new Operation(2, Operators.Multiply);

            Assert.NotNull(operation);
            Assert.Equal(2, operation.Value);
            Assert.Equal(Operators.Multiply, operation.Operator);
        }

        [Fact]
        public void CanChangeValuesInOperationInstance()
        {
            Operation operation = new Operation(2, Operators.Multiply);
            operation.SetValue(4);
            operation.SetOperator(Operators.Subtract);

            Assert.Equal(4, operation.Value);
            Assert.Equal(Operators.Devide, operation.Operator);
        }
        [Fact]
        public void CanChangeVlauesInOperationInstance()
        {
            Operation operation = new Operation(2, Operators.Multiply);
            operation.SetValue(4);
            operation.SetOperator(Operators.Add);

            Assert.Equal(4, operation.Value);
            Assert.Equal(Operators.Add, operation.Operator);
        }
        [Fact]
        public void CanChangeVlauesWithExtensionMethodsInAnOperationInstance()
        {
            Operation operation = new Operation(10, Operators.Multiply);
            operation.ChangeValue(20);
            operation.ChangeOperator(Operators.Devide);

            Assert.Equal(20, operation.Value);
            Assert.Equal(Operators.Devide, operation.Operator);            
        }
        [Fact]
        public void CanCalculateWithTheCalculateExtensionMethodInAnOperationInstance()
        {
            Operation operation1 = new Operation(10, Operators.Multiply);
            Operation operation2 = new Operation(20, Operators.Equal);

            var result = operation1.Calculate(operation2);

            Assert.Equal(200, result.Value);
            Assert.Equal(Operators.Equal, result.Operator);
        }
        [Fact]
        public void CanCreateCalculatorInstance()
        {
            Calculator calculator = new Calculator();

            Assert.NotNull(calculator);
        }
        [Fact]
        public void CanAddOperationToCalculatorInstance()
        {
            Calculator calculator = new Calculator();
            Operation operation = new Operation(10, Operators.Multiply);
            calculator.AddOperation(operation);

            Assert.Contains(operation, calculator.Operations);
        }
        [Fact]
        public void CanCalculateWithEmptyListCalculatorInstance()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate();

            Assert.Equal(default, result);
        }

        [Fact]
        public void CanCalculateWithOneOperationCalculatorInstance()
        {
            var calculator = new Calculator();
            var operation = new Operation(10, Operators.Multiply);
            calculator.AddOperation(operation);
            var result = calculator.Calculate();

            Assert.Equal(10, result);
        }

        [Fact]
        public void CanCalculateWithManyOperationsCalculatorInstance()
        {
            var calculator = new Calculator();
            var operation1 = new Operation(10, Operators.Multiply);
            var operation2 = new Operation(20, Operators.Devide);   // 200
            var operation3 = new Operation(2, Operators.Add);       // 100
            var operation4 = new Operation(30, Operators.Subtract); // 130
            var operation5 = new Operation(50, Operators.Equal);   //  80
            calculator.AddOperation(operation1);
            calculator.AddOperation(operation2);
            calculator.AddOperation(operation3);
            calculator.AddOperation(operation4);
            calculator.AddOperation(operation5);
            var result = calculator.Calculate();

            Assert.Equal(80, result);
        }
    }
}
