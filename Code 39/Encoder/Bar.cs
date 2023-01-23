using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_39.Encoder
{
    // [Bar Character Definition Class]
    class Bar
    {
        // [Fields]
        // Wide bars
        public const string WIDE = "███";
        public const string WIDE_SPACE = "   ";
        
        // Narrow bars
        public const string NARROW = "█";
        public const string NARROW_SPACE = " ";


        // [Methods]
        public static void QuietZone()
        {
            Console.Write(WIDE_SPACE);
        }
    }
}
