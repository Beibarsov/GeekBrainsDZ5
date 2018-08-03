using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//1. Создать программу, которая будет проверять корректность ввода логина.
//   Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры,
//    и при этом цифра не может быть первой.
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.



namespace GeekBrainsDZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            // myReg = new Regex(@"[A-Z]{2,8}");
            //if (myReg.IsMatch("QQQQQQQQQQQQQQQQQQQQQ"))
            //   Console.WriteLine("TRUE");

            //а) без использования регулярных выражений;
            //string str = Console.ReadLine();
            //char mychar = str[0];
            //if (str.Length > 1 && str.Length < 11 && char.GetNumericValue(mychar) == -1)
            //{
            //    Console.WriteLine("Логин корректный");
            //}

            //б) ** с использованием регулярных выражений
            Regex myregex = new Regex(@"[A-Za-z]+([A-Za-z0-9]{1,9})$");
            if (myregex.IsMatch("1UserUserUser"))
            {
                Console.WriteLine("Логин корректный");
            }


        }
    }
}
