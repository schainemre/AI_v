﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Country_or_Area = @"Åland Islands",
                Year = 2019F,
                Area = @"Total",
                Month = @"Total",
                Record_Type = @"Data tabulated by year of occurrence",
                Reliability = @"Final figure, complete",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Number_of_Births with predicted Number_of_Births from sample data...\n\n");


            Console.WriteLine($"Country_or_Area: {@"Åland Islands"}");
            Console.WriteLine($"Year: {2019F}");
            Console.WriteLine($"Area: {@"Total"}");
            Console.WriteLine($"Month: {@"Total"}");
            Console.WriteLine($"Record_Type: {@"Data tabulated by year of occurrence"}");
            Console.WriteLine($"Reliability: {@"Final figure, complete"}");
            Console.WriteLine($"Number_of_Births: {267F}");


            Console.WriteLine($"\n\nPredicted Number_of_Births: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}