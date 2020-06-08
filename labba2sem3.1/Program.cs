using System;

namespace labba2sem3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pr = "бвгжздйклмнпрстфхцчш";
            Console.WriteLine("Введіть рядок");
            string s = Console.ReadLine();
            string[] parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine();
            prigol(parts, Pr);
            palind(s, parts);
            Console.ReadKey();
        }
        public static void palind(string s, string[] darts)
        {

            for (int i = 0; i < darts.Length; i++)
            {
                bool del = true;
                int j = darts[i].Length - 1;
                for (int k = 0; k < darts[i].Length; k++)
                {
                    if (darts[i][k] != darts[i][j])
                    {
                        del = false;
                        break;
                    }
                    j--;
                }
                if (del)
                {
                    darts[i] = "";
                }

            }
            Console.WriteLine(string.Join("", darts));
        }
        public static void prigol(string[] parts, string Pr)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                int cnt = 0;
                for (int k = 0; k < parts[i].Length; k++)
                {
                    if (Pr.Contains(parts[i][k]))
                    {
                        cnt++;
                    }
                }
                vuvid(cnt, parts[i]);
            }

        }
        static void vuvid(int cnt, string parts)
        {
            if (cnt % 2 != 0)
            {
                Console.Write(parts + " ");
            }
        }

    }
}