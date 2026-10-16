//УРОК 1
//Задание 1
//Console.WriteLine("Hello world!");
//Console.WriteLine("Никита");

//Задание 2
//string slovo = "Hello World!";
//Console.WriteLine("Привет мир!");
//Console.WriteLine(slovo);

//Задание 3
//string name = "Никита";
//int age = 14;
//double height = 170.2;
//bool otvet = true;
//Console.WriteLine("Имя: " + name);
//Console.WriteLine("Возраст: " + age);
//Console.WriteLine("Рост: " + height);
//Console.WriteLine("Нравится ли мне программировать: " + otvet);

//Задание 4
//string name = "Никита";
//char firstLetter = 'Н';
//Console.WriteLine(name);
//Console.WriteLine(firstLetter);
//Если заменить переменную firstLetter на текст, выдадет ошибку

//Задание 5
//const int daysInWeek = 7;
//int age = 14;
//Console.WriteLine("Кол-во дней в неделе: " + daysInWeek);
//Console.WriteLine("Возраст: " +  age);
//Если попробовать поменять значение daysInWeek, то выдадет ошибку

//Задание 6
//int a = 3;
//int b = 6;
//Console.WriteLine("Сумма чисел: " + (a + b));
//Console.WriteLine("Разность чисел: " + (a - b));
//Console.WriteLine("Произведение чисел: " + (a * b));
//Console.WriteLine("Частное чисел: " + (a / b));

//Задание 7
//int a = 10;
//int b = 20;
//a += 10;
//b -= 30;
//Console.WriteLine(a);
//Console.WriteLine(b);

//Задание 8
//double height = 3;
//double width = 5.5;
//Console.WriteLine("Площадь прямоугольника: " + (height * width));
//Console.WriteLine("Периметр прямоугольника: " + (height + width) * 2);

//Задание 9
//int odin_tovar = 350;
//int vtoroy_tovar = 120;
//int discount = 50;
//Console.WriteLine("Стоимость товаров со скидкой: " + ((odin_tovar + vtoroy_tovar) - discount));

//Задание 10
//int number = 42;
//int a = 25;
//int b = 5;
//int c = 38;
//number = number + a - b + c;
//Console.WriteLine(number);

//Задание 11
//int a = 10;
//int b = 5;
//int c = 2;
//int resultPesyat = a * b;
//Console.WriteLine(resultPesyat);
//int resultCTO = a * b * c;
//Console.WriteLine(resultCTO);


//Шифр ЦЕЗАРЯ
//char[] Bykvi = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', };
//Console.WriteLine("Введите слово :");
//string userWord = Console.ReadLine();
//Console.WriteLine("На сколько символов нужно шифровать? ");
//int colvo = int.Parse(Console.ReadLine());
//int n = 0;
//int l = userWord.Length;

//while (n<=l)
//{


//    char itog = Bykvi[n + colvo];
//    Console.WriteLine(itog);
//    n = n + 1;

//}  //НЕДОДЕЛАНО

class Program
{
    static void Main()
    {
        //Урок 2

        //Калькулятор, задание 8
        //Console.WriteLine("Введите первое число: ");
        //int pervoe = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите второе число: ");
        //int vtoroe = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите тип операции: *,/,+,-");
        //string tip = Console.ReadLine();

        //int result = 0;
        //bool oshibka = true;
        //switch (tip)
        //{
        //    case "+":
        //        result = pervoe + vtoroe;
        //        break;
        //    case "-":
        //        result = pervoe - vtoroe;
        //        break;
        //    case "*":
        //        result = pervoe * vtoroe;
        //        break;
        //    case "/":
        //        if (vtoroe != 0)
        //        {
        //            result = pervoe / vtoroe;
        //            break;
        //        }
        //        else
        //        {
        //            oshibka = false; break;
        //        }
        //    default:
        //        Console.WriteLine("Ошибка, введите *, /, + или -");
        //        break;
        //}
        //if (oshibka = true)
        //{
        //    Console.WriteLine(result);
        //}

        //Задание 13
        //Калькулятор доставки
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Пиццерия у дома~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Введите название товара: ");
        string nazvanie = Console.ReadLine();
        Console.WriteLine("Введите стоимость товара (в рублях): ");
        double stoimost = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите вес товара (в килограммах): ");
        double ves = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите расстояние доставки (в метрах): ");
        double rasstoyanie = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите способ доставки: 1 - Обычная, 2 - Экспресс, 3 - Самовывоз");
        int sposob = int.Parse(Console.ReadLine());
        int stoimostVesa = 0;
        string tip = "Обычная";
        //Проверка ввода
        if (sposob != 1 & sposob != 2 & sposob != 3)
        {
            Console.WriteLine("Ошибка, вводите либо 1, либо 2, либо 3");
            return;
        }
        else
        {
            //Стоимость
            switch (sposob)
            {
                case 1:
                    if (ves <= 1)
                    {
                        stoimostVesa = 100;
                    }
                    if (ves > 1 & ves <= 5)
                    {
                        stoimostVesa = 200;
                    }
                    if (ves > 5 & ves <= 10)
                    {
                        stoimostVesa = 350;
                    }
                    if (ves > 10)
                    {
                        stoimostVesa = 500;
                    }
                    if (stoimost > 5000)
                    {
                        stoimostVesa = 0;
                    }
                    if (ves < 0 || ves == 0)
                    {
                        Console.WriteLine("Ошибка, вес не может быть отрицательным");
                    }
                    break;
                case 2:
                    if (ves <= 1)
                    {
                        stoimostVesa = 200;
                    }
                    if (ves > 1 & ves <= 5)
                    {
                        stoimostVesa = 400;
                    }
                    if (ves > 5 & ves <= 10)
                    {
                        stoimostVesa = 700;
                    }
                    if (ves > 10)
                    {
                        stoimostVesa = 1000;
                    }
                    if (stoimost > 5000)
                    {
                        stoimostVesa = 0;
                    }
                    if (ves < 0 || ves == 0)
                    {
                        Console.WriteLine("Ошибка, вес не может быть отрицательным");
                    }
                    break;
                case 3:
                    stoimostVesa = 0;
                    break;
            }
            switch (sposob)
            {
                case 1:
                    tip = "Обычная";
                    break;
                case 2:
                    tip = "Экспресс";
                    break;
                case 3:
                    tip = "Самовывоз";
                    break;
            }
            Console.WriteLine("Товар: " + nazvanie);
            Console.WriteLine("Стоимость товара: " + stoimost + " рублей");
            Console.WriteLine("Вес: " + ves + "кг");
            Console.WriteLine("Расстояние: " + rasstoyanie + "м");
            Console.WriteLine("Способ доставки: " + tip);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Стоимость доставки: " + stoimostVesa);
            Console.WriteLine("Итоговая стоимость: " + (stoimost + stoimostVesa));


            //Задание 15

            //Console.WriteLine("Введите своё имя: ");
            //string imya = Console.ReadLine();
            //Console.WriteLine("Введите свой возраст: ");
            //int vozrast = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите начальный баланс: ");
            //double balance = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите тип счёта: 1 - дебетовый, 2 - накопительный, 3 - премиальный");
            //int tipScheta = int.Parse(Console.ReadLine());
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("Выберите операцию: 1 - пополнить счёт, 2 - снять деньги, 3 - проверить баланс, 4 - получить информацию о счёте");
            //int operation = int.Parse(Console.ReadLine());
            //if (operation == 1)
            //{
            //    Console.WriteLine("На какую сумму вы хотите пополнить счёт?");
            //    double summaPopolneniya = double.Parse(Console.ReadLine());
            //    if (summaPopolneniya > 0 & summaPopolneniya != 0)
            //    {
            //        balance = balance + summaPopolneniya;   
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка");
            //    }

            //}
            //if (operation == 2)
            //{
            //    Console.WriteLine("Какую сумму вы хотите снять?");
            //    double summaSnyatiya = double.Parse(Console.ReadLine());
            //    if ()
            //}


        }
    }
}


