//9-17-21 (FRI.)
//This program will receive user input in the form of their weight, in lbs, and their height, in inches, as well as their name.
//It will take the weight and height and calculate the BMI from these values and print it out on the console.

using System;

namespace BMI_Calculator_Assignment2 
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string userInput;
            double weight;
            double height;
            double bmi;

            //We must name all the values we are using first.  I put these in the beginning to make it clear which values will be used.

            Console.WriteLine("Hello!  What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}. Do you want to use kg or lbs?  Please type 'kg' for kilograms or 'lbs' for pounds.", name);
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "kg")
            {
                Console.WriteLine("What is your weight in kg?");
                Console.WriteLine();
                weight = Convert.ToDouble(Console.ReadLine());
                weight = (weight * 2.204);

                //In this one we must convert the weight in kg to lbs.
                //We do this by multiplying the user input (after we convert it to a double) by '2.204'.
                //Since we are assigning a new value to the 'weight' double it will be used in all future calculations for the bmi value.

            }
            else if (userInput == "lbs")
            {
                Console.WriteLine("What is your weight in lbs?");
                Console.WriteLine();
                weight = Convert.ToDouble(Console.ReadLine());

                //Since the weight is already in the desired lbs we don't need to convert anything except for the user input to a double.
            }
            else
            {
                Console.WriteLine("Your answer is not understandable.  The computer will now choose 'lbs' as the default.  Please enter your weight in lbs.");
                Console.WriteLine();
                weight = Convert.ToDouble(Console.ReadLine());

                //If the user doesn't input information correctly, we give the default option to automatically
                //make the input in lbs for the computer to calculate.
            }

            

            //The user input must be converted to a double so it can be referenced later as a proper number with a decimal place.

            Console.WriteLine();

            Console.WriteLine("Thanks!  What is your height in inches?");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            bmi = (weight / (Math.Pow(height, 2))*703);

            //The bmi is calculated by this function.  math.pow takes the 'height' value and powers it by a num (2 in this case).

            Console.WriteLine("Based off of your inputs, {0}, your height is {1:F2} in inches, your weight is {2:F2} in lbs, and your BMI is {3:F2}",
                 name, height, weight, bmi);

            Console.WriteLine();

            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI is less than 18.5.  This signifies you are underweight.");
                Console.WriteLine("A recommended course of action would be to consume more calories than you burn");
            }
            if (bmi > 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Your BMI is between the ranges of 18.5 and 24.9.  This signifies you are at a healthy weight.");
                Console.WriteLine("Continue consuming the same amount of calories.");
            }
            if (bmi > 24.9)
            {
                Console.WriteLine("Your BMI is greater than 24.9.  This signifies you are overweight.");
                Console.WriteLine("A recommmended course of action would be to burn more calories than you consume.");
            }

            //These 'if' statements account for the bmi calculation made and suggests a certain action depending on what range the user's bmi is at.
            //The values seen here are typical bmi values for those who are underweight, normal weight, and overweight.

            Console.WriteLine();

          

        }
    }
}
