using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    // класс ParserEx наследует поля и методы класса Parser 
    // и перегружает родителский метод Parse c добавляет свой нового функционал, который 
    // вычисляет время за которое выполнялся парсинг
    class ParserEx : Parser
    {
        public ParserEx(string s) : base(s)
        {
        }

        public override int Parse(string s)
        {
            var ds = DateTime.Now;
            var r = base.Parse(s);
            Console.WriteLine("Время выполнения : {0} " ,(DateTime.Now - ds).TotalMilliseconds);
            return r;
        }

       
    }
}
