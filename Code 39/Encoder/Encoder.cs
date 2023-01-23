namespace Code_39.Encoder
{
    // [Barcode Encoder Engine Class]
    class Encoder
    {
        // [Properties]
        /* Barcode Properties:
        *  Symbol set contains 43 characters,
        *  A-Z, 0-9, and -, ., *, $, /, +, %, SPACE.
        */
        public static Code asterix = new Code('*', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});

        // [Barcode Properties: Numbers]
        public static Code numZero = new Code('0', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code numOne = new Code('1', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code numTwo = new Code('2', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code numThree = new Code('3', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code numFour = new Code('4', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code numFive = new Code('5', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code numSix = new Code('6', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code numSeven = new Code('7', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code numEight = new Code('8', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code numNine = new Code('9', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});

        // [Barcode Properties: Alphabet]
        public static Code letterA = new Code('a', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterB = new Code('b', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterC = new Code('c', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterD = new Code('d', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterE = new Code('e', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterF = new Code('f', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterG = new Code('g', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterH = new Code('h', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterI = new Code('i', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterJ = new Code('j', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterK = new Code('k', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE});
        public static Code letterL = new Code('l', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE});
        public static Code letterM = new Code('m', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterN = new Code('n', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE});
        public static Code letterO = new Code('o', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterP = new Code('p', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterQ = new Code('q', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.WIDE});
        public static Code letterR = new Code('r', new string[] {Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterS = new Code('s', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterT = new Code('t', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code letterU = new Code('u', new string[] {Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterV = new Code('v', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterW = new Code('w', new string[] {Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterX = new Code('x', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code letterY = new Code('y', new string[] {Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code letterZ = new Code('z', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});

        // [Barcode Properties: Miscellaneous]
        public static Code hyphen = new Code('-', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.WIDE});
        public static Code dot = new Code('.', new string[] {Bar.WIDE, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code space = new Code(' ', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.WIDE, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code dollor = new Code('$', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW});
        public static Code slash = new Code('/', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code plus = new Code('+', new string[] {Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});
        public static Code percent = new Code('%', new string[] {Bar.NARROW, Bar.NARROW_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW, Bar.WIDE_SPACE,
                                                           Bar.NARROW});

        // [Barcode Properties: Codepoints array]
        public static Code[] codes = {
                                     // Start/Stop Character
                                     asterix,
                                     // Numbers
                                     numZero, numOne, numTwo, numThree, numFour, numFive,
                                     numSix, numSeven, numEight, numNine, 
                                     // Alphabetic
                                     letterA, letterB, letterC, letterD, letterE, letterF,
                                     letterG, letterH, letterI, letterJ, letterK, letterL,
                                     letterM, letterN, letterO, letterP, letterQ, letterR,
                                     letterS, letterT, letterU, letterV, letterW, letterX,
                                     letterY, letterZ,
                                     // Miscellaneous
                                     hyphen, dot, space, dollor, slash, plus, percent};


        // [Methods]
        // Barcode Encoder
        // Encode text to barcode
        public static Code[] Encode(string text)
        {
            int counter = 0;
            Code[] buffer = new Code[text.Length];

            foreach (char character in text)
            {
                foreach (Code code in codes)
                {
                    try
                    {
                        if (character == code.Symbol)
                        {
                            buffer[counter++] = code;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"[ERROR] Something went wrong when reaing: {character}.");
                    }
                }
            }
            return buffer;
        }

        /* 
        * The * character presented below is not a true encodable character,
        * but is the start and stop symbol for Code 39.
        */
        // Add barcode start character => *
        public static Code[] AddStartCharacter(Code[] codes)
        {
            Code[] buffer = new Code[codes.Length + 1];
            buffer[0] = asterix;
            codes.CopyTo(buffer, 1);
            return buffer;
        }
        // Add barcode stop character => *
        public static Code[] AddEndCharacter(Code[] codes)
        {
            Code[] buffer = new Code[codes.Length + 1];
            buffer[buffer.Length - 1] = asterix;
            codes.CopyTo(buffer, 0);
            return buffer;
        }

        // Validating user input and cleaning it
        public static string Clean(string text)
        {
            string buffer;
            text = text.Trim();
            text = text.ToLower();
            if (text != "")
            {
                buffer = text.Replace("*", "-");
                return buffer;
            }
            else
            {
                return text;
            }
        }
    }
}
