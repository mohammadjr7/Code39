using Code_39.Encoder;

namespace Code_39
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Let's Code Here
            Console.Write("Input: ");
            string input = Encoder.Encoder.Clean(Console.ReadLine());

            Code[] code = Encoder.Encoder.Encode(input);

            code = Encoder.Encoder.AddStartCharacter(code);
            code = Encoder.Encoder.AddEndCharacter(code);

            Renderer.Renderer.SetBarcodeMode();
            Renderer.Renderer.RenderBarcode(code);
            Renderer.Renderer.RenderBarcode(code);
            Renderer.Renderer.RenderBarcode(code);
            Renderer.Renderer.RenderBarcode(code);
            Renderer.Renderer.RenderBarcode(code);
            Renderer.Renderer.SetTextMode();
        }
    }
}