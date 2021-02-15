using Xunit;
using System;
using production;

namespace productionTests
{
    public class TestPass 
    {
        
        [Fact]
        public void CalculteEmptyParameterTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(0, sumResult);
        //Then
        }

        [Fact]
        public void CalculteOneNumberInStringTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "5";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(5, sumResult);
        //Then
        }

         [Fact]
        public void CalculteSumOfTwoNumbersTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "9,2";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(11, sumResult);
        //Then
        }

        [Fact]
        public void CalculteSumOfAnyAmountOfNumbersTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "1,2,3,4";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(10, sumResult);
        //Then
        }

        [Fact]
        public void CalculteSumOfAnyAmountOfNumbersWithNewLineTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "1\n2,3";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(6, sumResult);
        //Then
        }

        [Fact]
        public void CalculteSumOfNumbersWithCustomDelimiterTest()
        {
        //Given
           var calculator = new Calculator();
           string  value = "//.\n1.2.3";
           int sumResult = calculator.Sum(value);
        //When
           Assert.Equal(6, sumResult);
        //Then
        }
    }
}

/*
1. Given the user input is empty when calculating the sum then it should return zero.
2. Given the user input is one number when calculating the sum then it should return the same number. (example "3" should equal 3)
3. Given the user input is two numbers when calculating the sum then it should return the sum of those numbers. (example "1,2" should equal 3)
4. Given the user input is an unknown amount of numbers when calculating the sum then it should return the sum of all the numbers. (example "1,2,3" should equal 6)
5. Given the user input is multiple numbers with new line and comma delimiters when calculating the sum then it should return the sum of all the numbers. (example "1\n2,3" should equal 6)
6. Given the user input is multiple numbers with a custom single-character delimiter when calculating the sum then it should return the sum of all the numbers. (example “//;\n1;2” should return 3)
7. Given the user input contains one negative number when calculating the sum then it should throw an exception "negatives not allowed: x" (where x is the negative number).
8. Given the user input contains multiple negative numbers mixed with positive numbers when calculating the sum then it should throw an exception "negatives not allowed: x, y, z" (where x, y, z are only the negative numbers). 
9. Given the user input contains numbers larger than 1000 when calculating the sum it should only sum the numbers less than 1001. (example 2 + 1001 = 2)
10. Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[***]\n1***2***3” should return 6)
11. Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[*][%]\n1*2%3” should return 6)
*/