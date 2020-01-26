using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal(3, result.Count, 1);
            Assert.Equal('B', result.Letter);
        }


        [Fact]
        public void ValuesCannotBeAddedOutsideInterval()
        {
            bool catch1 = false;
            bool catch2 = false;
            var book = new Book("Book 1");
            try
            {
                book.AddGrade(101.56);
            }
            catch(ArgumentException)
            {
                catch1 = true;
            }

            try
            {
                book.AddGrade(-10.34);
            }
            catch(ArgumentException)
            {
                catch2 = true;
            }
            
            var result = book.GetStatistics();

            Assert.Equal(0.0, result.Average, 1);
            Assert.Equal(0.0, result.High, 1);
            Assert.Equal(0.0, result.Low, 1);
            Assert.Equal(0.0, result.Count, 0);
            Assert.True(catch1);
            Assert.True(catch2);
        }
    }
}
