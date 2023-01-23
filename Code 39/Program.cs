using Code_39.Encoder;
using System;

namespace Code_39
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Let's Code Here
            Console.Write("Input: ");
            string inp = Encoder.Encoder.Clean(Console.ReadLine());

            Code[] c = Encoder.Encoder.Encode(inp);

            c = Encoder.Encoder.AddStartCharacter(c);
            c = Encoder.Encoder.AddEndCharacter(c);

            Renderer.Renderer.SetBarcodeMode();
            Renderer.Renderer.RenderBarcode(c);
            Renderer.Renderer.RenderBarcode(c);
            Renderer.Renderer.RenderBarcode(c);
            Renderer.Renderer.RenderBarcode(c);
            Renderer.Renderer.RenderBarcode(c);
            Renderer.Renderer.SetTextMode();
        }
    }
}