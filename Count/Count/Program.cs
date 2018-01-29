using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string stringOfOne = "";
            FileStream file = new FileStream("INPUT.TXT", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string str = reader.ReadToEnd();
            reader.Close();
            char[] arr;
            arr = str.ToCharArray();

            foreach (char c in arr)
            {
                if (c == 49)//В коді ASCII одиниця відповідає десятковому числу 49
                {
                    count++;
                    stringOfOne += c;
                }
            }

            StreamWriter writer = new StreamWriter("OUTPUT.TXT");
            writer.Write("Всього одиниць: " + count + ". Рядок одиниць: " + stringOfOne); // записуємо у файл
            writer.Close();
            Console.WriteLine("Кінець!");
            Console.ReadLine();
        }
    }
}
