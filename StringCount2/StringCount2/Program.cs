namespace StringCount2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello word";
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    a.Remove(i);
                    continue;
                }
                if (a[i] == 'a' || a[i] =='e' || a[i] =='i' || a[i] =='o' || a[i] =='u') vowels++;
                else consonants++;



            }
            Console.WriteLine("Your vowels count :" + vowels);
            Console.WriteLine("Your consonants count :" + consonants);


        }
    }
}