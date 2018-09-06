using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding("ISO-8859-1");

            string Text = Console.ReadLine();
            string text = Text.ToLower();
            List<string> censur = new List<string> {"vader","sled" };
            List<int> upper = new List<int> { };

            for (int j=0; j < Text.Length; j++)
            {
                if (Text[j] < 'Z' && Text[j] > 'A')
                {
                    upper.Add(j);
                }
            }

            foreach (string s in censur)
            {
                string asterisk = "";
                if (text.Contains(s))
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        asterisk += '*';
                    }
                    text = text.Replace(s,asterisk);
                }
            }

            Text = "";

            for (int k=0; k < text.Length; k++)
            {
                if (upper.Contains(k))
                {
                    Text += text[k].ToString().ToUpper();
                }
                else
                {
                    Text += text[k];
                }
            }

            Console.WriteLine(Text);
            Console.ReadKey();
        }
    }
}
