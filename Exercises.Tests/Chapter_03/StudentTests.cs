using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter_03;

namespace Exercises.Tests.Chapter_03
{
    public class StudentTests
    {
        [Fact]
        public void CanCreateStudentDefaultInstance()
        {
            var student = new Student();

            Assert.NotNull(student);
        }

        [Fact]
        public void CanCreateStudentInstanceWithParameters()
        {
            var student = new Student("Fernanda", "Ek", 30);

            Assert.NotNull(student);
            Assert.Equal(30, student.age);
            Assert.Equal("Fernanda Ek", student.FullName);
        }
    }
}
