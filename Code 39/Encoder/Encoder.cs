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


        // ------------------------------
        // TODO: Add remaining characters
        // ------------------------------

        // [Barcode Properties: Codepoints array]
        public static Code[] codes = {asterix, numZero, numOne, numTwo, numThree, numFour,
                                     numFive, numSix, numSeven, numEight, numNine};


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
                    if (character == code.Symbol)
                    {
                        buffer[counter++] = code;
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
            if (text != "")
            {
                buffer = text.Replace("*", "0"); //TODO: Replace with [-] hyphen
                return buffer;
            }
            else
            {
                return text;
            }
        }
    }
}
