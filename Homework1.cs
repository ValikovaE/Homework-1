

namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            if (number % 2 == 0)
            {
                System.Console.WriteLine("Number is even");
            }
            else if (number <= 0)
            {
                System.Console.WriteLine("Number should be greather than 0");
            }
            else
                System.Console.WriteLine("Number is odd");
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            string res = number % 4 == 0 ? "The number" + number + "divide to 4" : "The number" + number + "does not divide to 4";
            System.Console.WriteLine(res);
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                case "Monday":
                    System.Console.WriteLine(1);
                    break;
                case "Tuesday":
                    System.Console.WriteLine();
                    break;
                case "Wednesday":
                    System.Console.WriteLine();
                    break;
                case "Thursday":
                    System.Console.WriteLine();
                    break;
                case "Friday":
                    System.Console.WriteLine();
                    break;
                case "Saturday":
                    System.Console.WriteLine();
                    break;
                case "Sunday":
                    System.Console.WriteLine();
                    break;
                default:
                    System.Console.WriteLine("Wrong value! Please give a day of a week.");
                    break;
            
        }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            if (character == 'a' || character == 'e' || character == 'i' ||
                            character == 'o' || character == 'u')
                System.Console.WriteLine("Vowel");
            else
                System.Console.WriteLine("Consonant");

        }
        public static void Main(string[] args)
        {
            Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');

        }
    }
}

