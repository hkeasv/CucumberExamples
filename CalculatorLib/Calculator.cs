using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int CalculateShippingFee(ShippingMethod shippingMethod)
        {
            switch (shippingMethod)
            {
                case ShippingMethod.Standard:
                    return 20;
                case ShippingMethod.Expedited:
                    return 40;
                default:
                    return 20;
            }
        }

        public int CalculateAge(Person person)
        {
            int currentYear = 2024;
            int yearOfBirth = person.BirthDate.Year;
            return currentYear - yearOfBirth;
        }

    }

    public enum ShippingMethod { Standard, Expedited };
}
