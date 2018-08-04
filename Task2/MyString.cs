using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
    class MyString
    {
        string text;

        /// <summary>
        /// Конструктор с пустой строкой
        /// </summary>
        public MyString()
        {
            this.text = string.Empty;
        }

        public string Text
        {
            get
            {
                return text;
            }

        }


        /// <summary>
        /// Конструктор, где значение строки передаётся параметром
        /// </summary>
        /// <param name="text">Значение строки</param>
        public MyString(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Выводит из текста только те слова, где не больше требуемого букв
        /// </summary>
        public void WriteNeBoleeBukv()
        {


            //Math mymath = myregex.Match(text);
            //mymath.ToString();
            //Console.WriteLine(text.Length);
            
        }
    }
}
