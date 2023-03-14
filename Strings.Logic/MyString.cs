namespace Strings.Logic
{
    public class MyString
    {
        private readonly string _text;

        public MyString(string text)
        {
            _text = text;
        }

        public bool IsPalindrome()
        {
            string aux2 = _text.ToLower();
            aux2 = aux2.Replace('á', 'a');
            aux2 = aux2.Replace('é', 'e');
            aux2 = aux2.Replace('í', 'i');
            aux2 = aux2.Replace('ó', 'o');
            aux2 = aux2.Replace('ú', 'u');
            string aux = string.Empty;
            for (int i = 0; i < aux2.Length; i++)
            {
                if (!(aux2[i] == ' ' || aux2[i] == '.' || aux2[i] == ',' || aux2[i] == '¿' || aux2[i] == '?' || aux2[i] == '¡' || aux2[i] == '!' || aux2[i] == '\'' || aux2[i] == '"'))
                {
                    aux += aux2[i];
                }
            }

            int n = aux.Length / 2;
            for (int i = 0; i < n; i++)
            {
                if (aux[i] != aux[aux.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}