using System;
namespace MyProject
{
    internal class Hypotenuse
    {
        // Method to calculate the hypotenuse of a right-angled triangle
        public static double CalculateHypotenuse(double sideA, double sideB)
        {
            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
