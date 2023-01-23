using Code_39.Encoder;

namespace Code_39.Renderer
{
    // [Barcode Render Engine Class]
    class Renderer
    {
        // [Methods]
        /* Renderer Methdos: */
        // Console Color
        // Set Console Color to barcode settings
        public static void SetBarcodeMode()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        // Set Console Color to text settings
        public static void SetTextMode()
        {
            Console.ResetColor();
        }

        // Barcode Render
        // Console Barcode Renderer from String Pattern
        public static void RenderBarcode(string[] pattern)
        {
            foreach (string patternItem in pattern)
            {
                Console.Write(patternItem);
            }
            Console.Write(Bar.NARROW_SPACE);
        }

        // Console Barcode Renderer from Codepoint Array
        public static void RenderBarcode(Code[] codes)
        {
            RenderQuietZone();
            RenderQuietZone();
            foreach (Code code in codes)
            {
                RenderBarcode(code.Pattern);
            }
            RenderQuietZone();
            RenderQuietZone();
            Console.WriteLine();
        }

        // Barcode Quiet Zone Renderer
        public static void RenderQuietZone()
        {
            Bar.QuietZone();
        }
    }
}
