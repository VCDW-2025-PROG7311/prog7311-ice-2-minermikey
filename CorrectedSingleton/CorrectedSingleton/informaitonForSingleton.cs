using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrectedSingleton
{
    public class informaitonForSingleton
    {

        // Step 1: Private static variable to hold the single instance
        private static informaitonForSingleton _instance;
        private static object syncRoot = new object();


        // Step 2: Private constructor to prevent instantiation from outside
        private informaitonForSingleton()
        {
            // Initialize default settings
            StoreName = "Gadget Galaxy";
            Currency = "ZAR";
            TaxRate = 15.0; // Default tax rate
        }

        // Step 3: Public static method to get the instance
        public static informaitonForSingleton GetInstance()
        {
            if (_instance == null)
            {

                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new informaitonForSingleton();
                    }

                }
            }
            return _instance;
        }

        // Configuration Properties
        public string StoreName { get; private set; }
        public string Currency { get; private set; }
        public double TaxRate { get; private set; }

        // Method to update the tax rate
        public void UpdateTaxRate(double newRate)
        {
            TaxRate = newRate;
        }

        // Display current configuration settings
        public void DisplaySettings()
        {
            Console.WriteLine($"Store Name: {StoreName}");
            Console.WriteLine($"Currency: {Currency}");
            Console.WriteLine($"Tax Rate: {TaxRate}%");
            Console.WriteLine();
        }

    }
}