using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace IEnumerableExample
{
    internal class Program
    {
        //static IEnumerable<char> myReverse(IEnumerable<char> text, char match)
        static string myReverse(string text, char match)
        {
            foreach (var item in text.Reverse()) // LINQ Reverse
            {
                Console.Write(" " + item);
            }

            int number = (from c in text
                          where c == match
                          select c)
                          .Count();
            Console.WriteLine($"\nВ строке \"{text}\" насчитано {number} совпадений с \"{match}\"");
            //return text.Reverse<char>();
            return text.Reverse<char>().ToString();
        }
        static void PrintYear()
        {
            Year year = new Year();

            foreach (var month in year)
            {
                Console.WriteLine(month);
            }
        }
        static void PrintZZ()
        {
            ZZ _zz = new ZZ();

            foreach (var name in _zz)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Введите Знак Зодиака: ");
            string _ZZName = "";
            bool TF = true;
            do
            {
                _ZZName = Console.ReadLine();
                if (_ZZName == "Овен" || _ZZName == "овен")
                {
                    Console.WriteLine("21 марта - 20 апреля");
                    TF = false;
                }
                else if (_ZZName == "Телец" || _ZZName == "телец")
                {
                    Console.WriteLine("21 апреля	- 20 мая");
                    TF = false;
                }
                else if (_ZZName == "Близнецы" || _ZZName == "близнецы")
                {
                    Console.WriteLine("21 мая	- 21 июня");
                    TF = false;
                }
                else if (_ZZName == "Рак" || _ZZName == "рак")
                {
                    Console.WriteLine("22 июня	- 22 июля");
                    TF = false;
                }
                else if (_ZZName == "Лев" || _ZZName == "лев")
                {
                    Console.WriteLine("23 июля	- 23 августа");
                    TF = false;
                }
                else if (_ZZName == "Дева" || _ZZName == "дева")
                {
                    Console.WriteLine("24 августа	- 23 сентября");
                    TF = false;
                }
                else if (_ZZName == "Весы" || _ZZName == "весы")
                {
                    Console.WriteLine("24 сентября	- 23 октября");
                    TF = false;
                }
                else if (_ZZName == "Скорпион" || _ZZName == "скорпион")
                {
                    Console.WriteLine("24 октября	- 22 ноября");
                    TF = false;
                }
                else if (_ZZName == "Стрелец" || _ZZName == "стрелец")
                {
                    Console.WriteLine("23 ноября	- 21 декабря");
                    TF = false;
                }
                else if (_ZZName == "Козерог" || _ZZName == "козерог")
                {
                    Console.WriteLine("22 декабря	- 20 января");
                    TF = false;
                }
                else if (_ZZName == "Водолей" || _ZZName == "водолей")
                {
                    Console.WriteLine("21 января	- 18 февраля");
                    TF = false;
                }
                else if (_ZZName == "Рыбы" || _ZZName == "рыбы")
                {
                    Console.WriteLine("19 февраля	- 20 марта");
                    TF = false;
                }
                else
                {
                    Console.WriteLine("Такого Знака Зодиака нет!\nПопробуйте ещё раз!");
                    TF = true;
                }
            } while (TF);
        }

        static void Main(string[] args)
        {
            //PrintYear();

            PrintZZ();







            //////////
            /*Console.WriteLine("Введите строку: ");
            //IEnumerable<char> tmp = Console.ReadLine();
            string tmp = Console.ReadLine();
            Console.WriteLine("Введите символ для поиска: ");
            char ch = Console.ReadLine()[0];
            myReverse(tmp, ch);*/
        }
    }
}

// 1) Реализовать класс "Зодиакальный гороскоп" поддерживающий интерфейс IEnumerable
// 2) Реализовать класс "Восточный (по годам) гороскоп" поддерживающий интерфейс IEnumerable
// 3*) Реализовать класс "Гороскоп друидов" поддерживающий интерфейс IEnumerable
// Любая из 2-х реализаций должна:
// 1. Выдавать следующий знак;
// 2. Выдавать временные отрезки, принадлежащие знаку;
// 3. Выдавать описание;
// 4*. Позволять по дате рождения определять знак.