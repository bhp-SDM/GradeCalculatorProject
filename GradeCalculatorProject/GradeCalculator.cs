namespace GradeCalculatorProject
{
    public class GradeCalculator
    {
        public static int ToGrade(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("Percentage must be between 0 and 100 (inclusive)");
            if (percentage <= 7)
                return -3;
            else if (percentage <= 33)
                return 0;
            else if (percentage <= 41)
                return 2;
            else if (percentage <= 57)
                return 4;
            else if (percentage <= 77)
                return 7;
            else if (percentage <= 89)
                return 10;
            else 
                return 12;
        }
    }
}