using System;

namespace StudioOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable types go here yo
            string radiusInput;
            string mpgInput;
            double radius;
            double circleArea;
            double circumference;
            double diameter;
            double mpg;
            double requiredFuel;
            
           //Ask the user to input the radius
            Console.WriteLine("Enter the radius of your circle:");
            
            //Take that input and make it the radius ("make that a double!")
            radiusInput = Console.ReadLine();
            radius = double.Parse(radiusInput);
            
            //Calculate the area based on that radius
            circleArea = Math.PI * radius * radius;

            //Tell the user what the area of the circle is
            Console.WriteLine("The area of your cicle is " + circleArea);

            //But wait! Let's figure out the circumference and diameter, too!
            circumference = 2 * Math.PI * radius;
            diameter = 2 * radius;

            //Now let's tell the user this info, too!
            Console.WriteLine("The circumference of your cicle is: " + circumference);
            Console.WriteLine("The diameter of your cicle is: " + diameter);

            /*Let's pretend the user wants to drive in a big (or small) circle.
            Let's say the radius entered is in miles and that's how far they gotta go.*/

            //Let's ask them about their vehicle's fuel economy:
            Console.WriteLine("What is your vehicle's average MPG (how many miles per gallon average)?");
            
            //Gotta take their input and make it a number:
            mpgInput = Console.ReadLine();
            mpg = double.Parse(mpgInput);

            //Let's see how much fuel they will need to drive around this circle:
            requiredFuel = radius / mpg;
            //(I hope I'm doing the math right?)

            //Let's tell the user how much fuel they are going to need:
            Console.WriteLine("You will need " + requiredFuel + " gallons of gas to make it around your circle!");



        }
    }
}
