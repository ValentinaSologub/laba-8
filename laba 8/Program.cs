﻿using laba_8;
using System;

class Program
{
    static void Main()
    {
        var configManager = ConfigurationManager.Instance;

        Console.WriteLine("Current Configuration:");
        Console.WriteLine("Logging Mode: " + configManager.LoggingMode);
        Console.WriteLine("Database Connection: " + configManager.DatabaseConnection);

        Console.Write("\nEnter new Logging Mode: ");
        configManager.LoggingMode = Console.ReadLine();

        Console.Write("Enter new Database Connection: ");
        configManager.DatabaseConnection = Console.ReadLine();

        Console.WriteLine("\nUpdated Configuration:");
        Console.WriteLine("Logging Mode: " + configManager.LoggingMode);
        Console.WriteLine("Database Connection: " + configManager.DatabaseConnection);

        Console.ReadLine(); 
    }
}