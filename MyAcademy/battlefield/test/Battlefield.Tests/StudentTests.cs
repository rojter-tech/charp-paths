using System;
using Xunit;

namespace Battlefield.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var student = new ItStudent();
            student.SetStudentName("Danne");

            // act

            // assert
            Assert.Equal("Danne", student.GetStudentName());
        }
    }
}
