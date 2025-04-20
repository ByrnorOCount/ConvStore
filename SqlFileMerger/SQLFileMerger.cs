using System;
using System.IO;

namespace SqlFileMerger
{
    public class SqlFileMerger
    {
        public SqlFileMerger()
        {
            // Define the base directory relative to the project
            string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\ConvStore\sql");

            // Define the SQL file paths relative to the base directory
            string[] sqlFilePaths = new string[]
            {
                Path.Combine(baseDirectory, "Database.sql"),
                Path.Combine(baseDirectory, "Table.sql"),
                Path.Combine(baseDirectory, "Trigger.sql"),
                Path.Combine(baseDirectory, "View.sql"),
                Path.Combine(baseDirectory, "Procedure.sql"),
                Path.Combine(baseDirectory, "Function.sql")
            };

            // Define the output file path
            string outputFilePath = Path.Combine(baseDirectory, "ConvStore_DB.sql");

            try
            {
                // Create or overwrite the output file
                using (StreamWriter outputFile = new StreamWriter(outputFilePath, false))
                {
                    foreach (string filePath in sqlFilePaths)
                    {
                        if (File.Exists(filePath))
                        {
                            // Read the content of the small SQL file
                            string fileContent = File.ReadAllText(filePath);

                            // Write the content to the big SQL file
                            outputFile.WriteLine("-- Begin File: " + Path.GetFileName(filePath));
                            outputFile.WriteLine(fileContent);
                            outputFile.WriteLine("-- End File: " + Path.GetFileName(filePath));
                            outputFile.WriteLine(); // Adding a blank line between files
                        }
                        else
                        {
                            Console.WriteLine($"File not found: {filePath}");
                        }
                    }
                }

                Console.WriteLine($"Complete SQL file generated successfully: {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}