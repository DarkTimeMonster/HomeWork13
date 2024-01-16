using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа, ввести с экрана вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.
            Console.WriteLine("Вся информация может обрабатываться компьютером если она предоставлена(Ответ дать ввиде числа от 1 до 3):");
            Console.WriteLine($"1) в двоичной знаковой системе\n2) в десятичной знаковой системе\n3) в виде символов и чисел");
            byte answer = byte.Parse( Console.ReadLine());
            switch(answer)
            {
                case 1:
                    Console.WriteLine("Правильно");
                    break;
                case 1':
                    Console.WriteLine("Неправильно");Console.Write("В двоичной знаковой системе");
                    break;
                case 1:
                    Console.WriteLine("Неправильно");Console.Write("В двоичной знаковой системе");
                    break;
            
            default:
                    Console.WriteLine("Такого ответа нет");
            break;
            }*/

            //2. Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20% скидка. Ввести продолжительность разговора и день недели (цифра от 1 до 7).
            /*
            Console.WriteLine("Выберите день переговоров - ");
            Console.WriteLine($"1) Понедельник\n2) Вторник\n3) Среда\n4) Четверг\n5) Пятница\n6) Суббота\n7) Воскресенье");
            byte Day = byte.Parse( Console.ReadLine());
            Console.WriteLine("Введите время переговоров в часах - ");
            int Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену переговоров за час - ");
            int PriceHoours = int.Parse(Console.ReadLine());
            double itogprice = 0;
            switch (Day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    itogprice = Hours * PriceHoours;
                    Console.WriteLine($"Ваши переговоры запланированы.Стоимость составляет - {itogprice} ");
                    break;
                case 6:
                case 7:
                    itogprice = Hours * PriceHoours * 0.8;
                    Console.WriteLine($"Ваши переговоры запланированы.Стоимость составляет - {itogprice} ");
                    break;

                default:
                    Console.WriteLine("Такого дня недели нет");
                    break;
            }
            */
            //4. Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому, умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13, от 2 до 5 лет – 16. Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5) и вывести сообщение о приеме в магистратуру при проходном балле 45.
            /*
            Console.WriteLine("Введите средний балл по диплому (от 3 до 5):");
            double SrBall = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стаж работы по специальности (в годах):");
            double workExp = Convert.ToDouble(Console.ReadLine());

            double coefficient;
            if (workExp == 0)
                {
                coefficient = 1;
                }
            else if (workExp < 2)
                {
                coefficient = 13;
                }
            else if (workExp <= 5 && workExp >= 2)
                {
                coefficient = 16;
                }
            else
                {
                Console.WriteLine("Некорректное значение стажа работы.");
                return;
                }
            double rate = SrBall * coefficient;

            Console.WriteLine($"Рейтинг бакалавра: {rate}");

            if (rate >= 45)
                {
                Console.WriteLine("Поздравляем! Вы приняты в магистратуру.");
                }
            else
                {
                Console.WriteLine("К сожалению, ваш рейтинг не соответствует проходному баллу.");
                }
            */

            //5.Написать программу , которая по дате рождения(день d месяц n) определяет знак Зодиака: с 22 марта по 21 апреля - Овен(4); с 22 апреля по 21 мая - Телец(5); с 22 мая по 21 июня - Близнецы(6); с 22 июня по 21 июля - Рак(7); с 22 июля по 21 августа - Лев(8); с 22 августа по 21 сентября - Дева(9); 22 сентября по 21 октября - Весы(10); с 22 октября по 21 ноября - Скорпион(11); с 22 ноября по 21 декабря - Стрелец(12); с 22 декабря по 21 января - Козерог(1); 22 января по 21 февраля - Водолей(2); с 22 февраля по 21 марта - Рыбы(3).
            /*
             Console.WriteLine("Введите день рождения:");
             int day = int.Parse(Console.ReadLine());

             Console.WriteLine("Введите номер месяца рождения:");
             int month = int.Parse(Console.ReadLine());

             string zodiacSign;

             if ((month == 3 && day >= 22) || (month == 4 && day <= 21))
             {
                 zodiacSign = "Овен (4)";
             }
             else if ((month == 4 && day >= 22) || (month == 5 && day <= 21))
             {
                 zodiacSign = "Телец (5)";
             }
             else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
             {
                 zodiacSign = "Близнецы (6)";
             }
             else if ((month == 6 && day >= 22) || (month == 7 && day <= 21))
             {
                 zodiacSign = "Рак (7)";
             }
             else if ((month == 7 && day >= 22) || (month == 8 && day <= 21))
             {
                 zodiacSign = "Лев (8)";
             }
             else if ((month == 8 && day >= 22) || (month == 9 && day <= 21))
             {
                 zodiacSign = "Дева (9)";
             }
             else if ((month == 9 && day >= 22) || (month == 10 && day <= 21))
             {
                 zodiacSign = "Весы (10)";
             }
             else if ((month == 10 && day >= 22) || (month == 11 && day <= 21))
             {
                 zodiacSign = "Скорпион (11)";
             }
             else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
             {
                 zodiacSign = "Стрелец (12)";
             }
             else if ((month == 12 && day >= 22) || (month == 1 && day <= 21))
             {
                 zodiacSign = "Козерог (1)";
             }
             else if ((month == 1 && day >= 22) || (month == 2 && day <= 21))
             {
                 zodiacSign = "Водолей (2)";
             }
             else if ((month == 2 && day >= 22) || (month == 3 && day <= 21))
             {
                 zodiacSign = "Рыбы (3)";
             }
             else
             {
                 zodiacSign = "Некорректная дата рождения";
             }

             Console.WriteLine($"Ваш знак Зодиака: {zodiacSign}");
            */
            //6. Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка" в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки. 
            /*
            Console.WriteLine("Введите число от 1 до 99:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 99)
            {
                Console.WriteLine("Число должно быть в диапазоне от 1 до 99.");
                return;
            }

            string kop;

            int onenumb = number % 10;
            int twonumb = (number / 10) % 10;

            if (twonumb == 1)
            {
                kop = "копеек";
            }
            else
            {
                switch (onenumb)
                {
                    case 1:
                        kop = "копейка";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        kop = "копейки";
                        break;
                    default:
                        kop = "копеек";
                        break;
                }
            }

            Console.WriteLine($"Вы ввели: {number} {kop}");
            */
            //Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.

            Console.WriteLine("Введите число от 1 до 99:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 99)
            {
                Console.WriteLine("Число должно быть в диапазоне от 1 до 99.");
                return;
            }

            string rub;

            int onenumb = number % 10;
            int twonumb = (number / 10) % 10;

            if (twonumb == 1)
            {
                rub = "рублей";
            }
            else
            {
                switch (onenumb)
                {
                    case 1:
                        rub = "рубль";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        rub = "рубля";
                        break;
                    default:
                        rub = "рублей";
                        break;
                }
            }

            Console.WriteLine($"Вы ввели: {number} {rub}");
            Console.ReadKey();
        }
    }
}
