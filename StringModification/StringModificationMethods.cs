namespace StringModification
{
    public class StringModificationMethods
    {
        public string StringBackwards(string originalString)
        {
            char[] stringArray = originalString.ToCharArray();
            char[] backwordsWordArray = new char[stringArray.Length];
            int backwordsStringArrayIndex = 0;
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                backwordsWordArray[backwordsStringArrayIndex] = stringArray[i];
                backwordsStringArrayIndex++;
            }
            string backwordsString = new string(backwordsWordArray);
            return backwordsString;
        }
        public string StringToAllLowerCase(string originalString)
        {
            char[] stringArray = originalString.ToCharArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Char.ToLower(stringArray[i]);
            }
            string allLowerCaseString = new string(stringArray);
            return allLowerCaseString;
        }
        public string StringToAllCaps(string originalString)
        {
            char[] stringArray = originalString.ToCharArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Char.ToUpper(stringArray[i]);
            }
            string allUpperCaseString = new string(stringArray);
            return allUpperCaseString;
        }
    }
}
