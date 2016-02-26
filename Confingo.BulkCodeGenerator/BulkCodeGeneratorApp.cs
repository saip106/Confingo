using System;
using System.IO;
using System.Text;
using Confingo.BusinessLayer;

namespace Confingo.BulkCodeGenerator
{
    internal class BulkCodeGeneratorApp
    {
        private readonly UniqueCodeGenerator _uniqueCodeGenerator;

        public BulkCodeGeneratorApp(UniqueCodeGenerator uniqueCodeGenerator)
        {
            _uniqueCodeGenerator = uniqueCodeGenerator;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to Configo Bulk Code Genrator App");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Please enter the number of codes you would like to generate:");
            var numberOfCodesToGenerateText = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numberOfCodesToGenerateText))
            {
                Console.WriteLine("The value {0} you entered in invalid", numberOfCodesToGenerateText);
                Console.WriteLine("Please enter a valid number to try again");
            }
            else
            {
                int numberOfCodesToGenerate;
                var isValidNumber = int.TryParse(numberOfCodesToGenerateText, out numberOfCodesToGenerate);
                if (isValidNumber && numberOfCodesToGenerate > 0)
                {
                    var codes = new StringBuilder();
                    for (var i = 0; i < numberOfCodesToGenerate; i++)
                    {
                        var uniqueKey = _uniqueCodeGenerator.GetUniqueKey();
                        codes.AppendLine(uniqueKey);
                    }

                    var fileName = string.Format("codes-{0}.txt", DateTime.Now.ToFileTime());
                    var filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                    File.WriteAllText(filePath, codes.ToString());
                    Console.WriteLine("Please find codes in {0}", filePath);
                }
                else
                {
                    Console.WriteLine("The value {0} you entered in invalid", numberOfCodesToGenerateText);
                }
            }
            Console.ReadLine();
        }
    }
}