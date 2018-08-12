using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump + i + 1;

                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }

                string matchedString = text.Substring(i, jump + 1);
                Console.WriteLine(matchedString);
                i += jump + 1;

            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
