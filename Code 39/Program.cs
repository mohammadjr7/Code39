using Code_39.Encoder;

namespace Code_39
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "?" || args[0] == "/?")
            {
                // Defualt help message
                Console.WriteLine("Generates Code39 Barcodes in console.");
                Console.WriteLine();
                Console.WriteLine("Usage: \"Code 39.exe\" [message]");
                Console.WriteLine();
                Console.WriteLine("Symbol set contains 43 characters:");
                Console.WriteLine("\tA-Z, 0-9, and -, ., $, /, +, %, SPACE.");
                Console.WriteLine();
                Console.WriteLine("Examples: ");
                Console.WriteLine("\t\"Code 39.exe\" Hello");
                Console.WriteLine("\t\"Code 39.exe\" /Javad/");
                Console.WriteLine("\t\"Code 39.exe\" 4457");
                Console.WriteLine("\t\"Code 39.exe\" \"A long message\"");
            }
            else
            {
                string input = Encoder.Encoder.Clean(args[0]);

                Code[] code = Encoder.Encoder.Encode(input);
                Renderer.Renderer.ValidateBarcode(code, input);
                code = Encoder.Encoder.AddStartCharacter(code);
                code = Encoder.Encoder.AddEndCharacter(code);

                Console.WriteLine();
                Console.WriteLine($"Generating barcode for [{input}]: ");
                Renderer.Renderer.SetBarcodeMode();
                Renderer.Renderer.RenderQuietZone(code.Length);
                Renderer.Renderer.RenderBarcode(height:8 , code);
                Renderer.Renderer.RenderQuietZone(code.Length);
                Renderer.Renderer.SetTextMode();

                // Render user input at the center of barcode
                for (int i = 0; i < (code.Length * 9); i++)
                {
                    Console.Write(" ");
                }
                Console.Write($"{input.ToUpper()}");
                Console.WriteLine();
            }
        }
    }
}
