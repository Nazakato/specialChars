namespace SpecialChars
{
    public class Class1
    {
        public string LongestSbustringOfTwoChars(string str)
        {
            if (str is null) return null;

            var pointerLeft = -1;
            var pointerRight = -1;
            var maxSubstringPointerRight = pointerRight;
            var maxSubstringPointerLeft = pointerLeft;

            var hashMap = Enumerable.Repeat(0, 26).ToArray();

            while (true)
            {
                // Pushes back the right pointer
                while (pointerRight < str.Length - 1 && HasAtMostTwoDifferentLetters(hashMap))
                {
                    pointerRight++;
                    hashMap[str[pointerRight] - 97]++;

                    if (pointerRight - pointerLeft > maxSubstringPointerRight - maxSubstringPointerLeft)
                    {
                        maxSubstringPointerRight = pointerRight;
                        maxSubstringPointerLeft = pointerLeft;
                    }
                }

                if (pointerRight == str.Length - 1) break;

                // Pushes back the left pointer
                while (!HasAtMostTwoDifferentLetters(hashMap))
                {
                    pointerLeft++;
                    hashMap[str[pointerLeft] - 97]--;
                }
            }

            return str.Substring(maxSubstringPointerLeft + 1, maxSubstringPointerRight - maxSubstringPointerLeft - 1);
        }

        private static bool HasAtMostTwoDifferentLetters(int[] alphabet)
        {
            return alphabet.Where(c => c != 0).Count() <= 2;
        }
    }
}