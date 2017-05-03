using System;

namespace _12.CurrencyConverter
{
    class CurrencyConverterExercise
    {
        static void Main(string[] args)
        {
            double bgnInUsd = 1.79549;
            double bgnInEuro = 1.95583;
            double bgnInGbp = 2.53405;

            double eurInUsd = bgnInEuro / bgnInUsd;
            double eurInGbp = bgnInEuro / bgnInGbp;

            double usdInGbp = bgnInUsd / bgnInGbp;

            double sourceCurrencyAmount = double.Parse(
                Console.ReadLine());
            string sourceCurrencyName = 
                Console.ReadLine();
            string convertedCurrencyName = 
                Console.ReadLine();

            double convertedCurrencyAmount = -1.0;
            string usdCurrencyCode = "USD";
            string bgnCurrencyCode = "BGN";
            string euroCurrencyCode = "EUR";
            string greatBritanPoundCurrencyCode = "GBP";

            if (sourceCurrencyName == usdCurrencyCode)
            {
                if (convertedCurrencyName == bgnCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * bgnInUsd;
                }

                if (convertedCurrencyName == euroCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / eurInUsd;
                }

                if (convertedCurrencyName == greatBritanPoundCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * usdInGbp;
                }
            }

            if (sourceCurrencyName == euroCurrencyCode)
            {
                if (convertedCurrencyName == bgnCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * bgnInEuro;
                }

                if (convertedCurrencyName == usdCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * eurInUsd;
                }

                if (convertedCurrencyName == greatBritanPoundCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * eurInGbp;
                }
            }

            if (sourceCurrencyName == greatBritanPoundCurrencyCode)
            {
                if (convertedCurrencyName == bgnCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount * bgnInGbp;
                }

                if (convertedCurrencyName == usdCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / usdInGbp;
                }

                if (convertedCurrencyName == euroCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / eurInGbp;
                }
            }

            if (sourceCurrencyName == bgnCurrencyCode)
            {
                if (convertedCurrencyName == euroCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / bgnInEuro;
                }

                if (convertedCurrencyName == usdCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / bgnInUsd;
                }

                if (convertedCurrencyName == greatBritanPoundCurrencyCode)
                {
                    convertedCurrencyAmount = 
                        sourceCurrencyAmount / bgnInGbp;
                }
            }

            Console.WriteLine("{0:F2} {1}", 
                convertedCurrencyAmount, convertedCurrencyName);
        }
    }
}
