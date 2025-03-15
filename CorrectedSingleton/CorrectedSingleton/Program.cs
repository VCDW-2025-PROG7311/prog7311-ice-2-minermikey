
using CorrectedSingleton;

    
        // Retrieve the singleton instance
        var config1 = informaitonForSingleton.GetInstance();
        
        // Display initial settings
        Console.WriteLine("Initial Configuration:");
        config1.DisplaySettings();

        // Retrieve another instance and update the tax rate
        var config2 = informaitonForSingleton.GetInstance();
        config2.UpdateTaxRate(18.0);

        // Display settings again to confirm the update is reflected
        Console.WriteLine("Updated Configuration:");
        config1.DisplaySettings(); // Using first reference
        config2.DisplaySettings(); // Using second reference

        // Verify if both instances are the same
        Console.WriteLine($"Are both instances the same? {object.ReferenceEquals(config1, config2)}");
    