using System;
using System.IO;

namespace SqlFileMerger
{
    public class SqlFileMerger
    {
        public SqlFileMerger()
        {
            string[] sqlFilePaths = new string[]
            {
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\Database.sql",
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\Table.sql",
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\Trigger.sql",
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\View.sql",
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\Procedure.sql",
                @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\Function.sql"
            };

            string outputFilePath = @"D:\HCMUTE\Database_Management_System\ConvStore\ConvStore\Sql\ConvStore_DB.sql";

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

                Console.WriteLine($"Big SQL file generated successfully: {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}