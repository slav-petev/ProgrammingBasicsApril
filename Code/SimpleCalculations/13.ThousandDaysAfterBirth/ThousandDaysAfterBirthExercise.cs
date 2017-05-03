using System;
using System.Globalization;

namespace _13.ThousandDaysAfterBirth
{
    class ThousandDaysAfterBirthExercise
    {
        static void Main(string[] args)
        {
            var birthdate = DateTime
                .ParseExact(Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            var thousandDaysAfterBirth =
                birthdate.AddDays(999);

            Console.WriteLine(
                thousandDaysAfterBirth.ToString("dd-MM-yyyy"));
        }
    }
}
