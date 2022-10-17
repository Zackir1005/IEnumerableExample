using System.Collections;


namespace IEnumerableExample
{
    class Year : IEnumerable
    {
        string[] months = { "Январь", "Февраль", "Март", "Апрель",
                         "Май", "Июнь", "Июль", "Август", "Сентябрь",
                         "Октябрь", "Ноябрь", "Декабрь" };
        public IEnumerator GetEnumerator() => months.GetEnumerator();
    }
    class ZZ : IEnumerable
    {
        string[] zz = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
        public IEnumerator GetEnumerator() => zz.GetEnumerator();
    }
    class ChineseРoroscope : IEnumerable
    {
        string[] vz = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
        public IEnumerator GetEnumerator() => vz.GetEnumerator();
    }
}
