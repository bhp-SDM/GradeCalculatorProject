using GradeCalculatorProject;

namespace XUnitTestProject
{
    public class GradeCalculatorTest
    {                           //  User story: 1
        [Theory]
        [InlineData(-1)]        // Test case 1.1
        [InlineData(101)]       // Test case 1.2
        public void ToGradeInvalidPercentageExpectArgumentException(int percentage)
        {
            // Act + Assert
            Assert.Throws<ArgumentException>(() => GradeCalculator.ToGrade(percentage));
        }

        [Theory]
        [InlineData(0, -3)]     // test case 1.3
        [InlineData(7, -3)]     // test case 1.4
        [InlineData(8, 0)]      // test case 1.5
        [InlineData(33, 0)]     // test case 1.6
        [InlineData(34, 2)]     // test case 1.7
        [InlineData(41, 2)]     // test case 1.8
        [InlineData(42, 4)]     // test case 1.9
        [InlineData(57, 4)]     // test case 1.10
        [InlineData(58, 7)]     // test case 1.11
        [InlineData(77,7)]      // test case 1.12
        [InlineData(78, 10)]    // test case 1.13
        [InlineData(89, 10)]    // test case 1.14
        [InlineData(90, 12)]    // test case 1.15
        [InlineData(100,12)]    // test case 1.16
        public void ToGradeValidPercentageInput(int percentage, int expected)
        {
            // Act
            int grade = GradeCalculator.ToGrade(percentage);

            //Assert
            Assert.Equal(expected, grade);
        }

    }
}