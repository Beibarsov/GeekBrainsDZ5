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

            Regex myregex = new Regex(@"[а-яА-Я0-9]+\>");
            myregex.
                Console.WriteLine(str);
            //Console.WriteLine(text.Length);
            
        }
    }
}
