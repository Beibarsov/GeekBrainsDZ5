using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Разработать методы для решения следующих задач.Дано сообщение:
//а) Вывести только те слова сообщения, которые содержат не более чем n букв;
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
//в) Найти самое длинное слово сообщения;
//г) Найти все самые длинные слова сообщения.
//Постараться разработать класс MyString.


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString mystring = new MyString("Шла Саша по шоссе и цйуйуйуйц");
            mystring.WriteNeBoleeBukv();
        }
    }
}
