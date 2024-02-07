using Xunit;
namespace UnitTesting1.Tests
{
    //TestSuite
    public class StringCalculatorAddOPerationTestSuite
    {


        /*[Theory]
        [InlineData("", 0)]
        [InlineData("1,2", 3)]
        public void GivenInputStringOutputIntegerExpected(string input, int expectedResult)

        {

            int actualResult = StringCalculator.Add(input);

            Assert.Equal(expectedResult, actualResult);

        }
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("1\n2,3", 6)]
        [InlineData("2,1001", 2)]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//[*]\n1**2**3", 6)]
        [InlineData("//[*][%]\n1*2%3", 6)]
        public void GivenNumbersSeparatedByDelimiter_WhenAddIsCalled_ThenResultShouldBeSumOfNumbers(string input, int expectedResult)
        {
            int actualResult = StringCalculator.Add(input);

            Assert.Equal(expectedResult, actualResult);
        }*/
        [Theory]
        [ClassData(typeof(StringCalcTestInputData))]
        public void GivenInputStringOutputIntegerExpected(string input, int expectedResult)
        {
            int actualResult = StringCalculator.Add(input);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact] //TestCase
        public void GivenEmptyStringInputZeroIsExpected()
        {
            //AAA
            string input = "";
            int expectedResult = 0;
            //Act

            int actualResult = UnitTesting1.StringCalculator.Add(input);

            Assert.Equal(expectedResult, actualResult);


        }
        [Fact]
        public void GivensingleStringInputSameDigitExpected()
        {
            string input = "1";
            int expectedResult = 1;

            int actualResult = UnitTesting1.StringCalculator.Add(input);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void GivenNegativeNumberInput_ExceptionIsThrown()
        {
            // Arrange
            string input = "-2";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(input));
        }
        [Fact]
        public void NewLinesBetweenNumbers_ShouldReturnSum()
        {
            // Given
            string input = "1\n2,3";
            int expectedResult = 6;

            // When
            int actualResult = StringCalculator.Add(input);

            // Then
            Assert.Equal(expectedResult, actualResult);
        }

      



        [Fact]
        public void NumbersBiggerThan1000_ShouldIgnoreAndReturnSum()
        {
            // Given
            string input = "2,1001";
            int expectedResult = 2;

            // When
            int actualResult = StringCalculator.Add(input);

            // Then
            Assert.Equal(expectedResult, actualResult);
        }





    }
}
