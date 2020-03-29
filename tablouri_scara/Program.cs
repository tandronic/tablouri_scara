using System;

namespace tablouri_scara
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] date = new string[26][];
            for(int i=0; i<26; i++)
            {
                date[i] = new string[1];
                date[i][0] = char.ConvertFromUtf32(65 + i);
            }
            
            foreach (var arg in args)
            {
                for (int i = 0; i < 26; i++)
                {
                    if(date[i][0][0] == char.ToUpper(arg[0]))
                    {
                        System.Array.Resize(ref date[i], date[i].Length + 1);
                        date[i][date[i].Length - 1] = arg;
                    }
                }
            }
            for (int i = 0; i < 26; i++)
            {
                string rez = date[i][0] + " : ";
                for (int j = 1; j < date[i].Length; j++)
                    rez += date[i][j] + " ";
                Console.WriteLine(rez);
            }
        }
    }
}
