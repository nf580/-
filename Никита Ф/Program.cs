//УРОК 1
//Задание 1
//Console.WriteLine("Hello world!");
//Console.WriteLine("Никита");

//Задание 2
//string word = "Hello World!";
//Console.WriteLine("Привет мир!");
//Console.WriteLine(word);

//Задание 3
//string name = "Никита";
//int age = 14;
//double height = 170.2;
//bool answer = true;
//Console.WriteLine("Имя: " + name);
//Console.WriteLine("Возраст: " + age);
//Console.WriteLine("Рост: " + height);
//Console.WriteLine("Нравится ли мне программировать: " + answer);

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
//int first = 350;
//int second = 120;
//int discount = 50;
//Console.WriteLine("Стоимость товаров со скидкой: " + ((first + second) - discount));

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
//int fifty = a * b;
//Console.WriteLine(fifty);
//int hundred = a * b * c;
//Console.WriteLine(hundred);


//Шифр ЦЕЗАРЯ
//char[] letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', };
//Console.WriteLine("Введите слово :");
//string userWord = Console.ReadLine();
//Console.WriteLine("На сколько символов нужно шифровать? ");
//int colvo = int.Parse(Console.ReadLine());
//int n = 0;
//int l = userWord.Length;

//while (n<=l)
//{


//    char itog = letters[n + colvo];
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
        //int first = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите второе число: ");
        //int second = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите тип операции: *,/,+,-");
        //string type = Console.ReadLine();

        //int result = 0;
        //bool error = true;
        //switch (type)
        //{
        //    case "+":
        //        result = first + second;
        //        break;
        //    case "-":
        //        result = first - second;
        //        break;
        //    case "*":
        //        result = first * second;
        //        break;
        //    case "/":
        //        if (second != 0)
        //        {
        //            result = first / second;
        //            break;
        //        }
        //        else
        //        {
        //            error = false; Console.WriteLine("Ошибка, делить на 0 нельзя")
        //            break;
        //        }
        //    default:
        //        Console.WriteLine("Ошибка, введите *, /, + или -");
        //        break;
        //}
        //if (error = true)
        //{
        //    Console.WriteLine(result);
        //}

        //Задание 13
        //Калькулятор доставки
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Пиццерия у дома~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        //Получение данных
        Console.WriteLine("Введите название товара: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите стоимость товара (в рублях): ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите вес товара (в килограммах): ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите расстояние доставки (в метрах): ");
        double distance = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите способ доставки: 1 - Обычная, 2 - Экспресс, 3 - Самовывоз");
        int type = int.Parse(Console.ReadLine());
        int priceWeight = 0;
        string tip = "Обычная";
        //Обработка данных
        //Проверка ввода
        
        if (type > 3 & type<1)
        {
            Console.WriteLine("Ошибка, вводите либо 1, либо 2, либо 3");
            return;
        }
        else
        {
            //Стоимость
            switch (type)
            {
                case 1:
                    if (weight <= 1)
                    {
                        priceWeight = 100;
                    }
                    else if (weight > 1 & weight <= 5)
                    {
                        priceWeight = 200;
                    }
                    else if (weight > 5 & weight <= 10)
                    {
                        priceWeight = 350;
                    }
                    else if (weight > 10)
                    {
                        priceWeight = 500;
                    }
                    else if (price > 5000)
                    {
                        priceWeight = 0;
                    }
                    else if (weight < 0 || weight == 0)
                    {
                        Console.WriteLine("Ошибка, вес не может быть отрицательным");
                    }
                    break;
                case 2:
                    if (weight <= 1)
                    {
                        priceWeight = 200;
                    }
                    else if (weight > 1 & weight <= 5)
                    {
                        priceWeight = 400;
                    }
                    else if (weight > 5 & weight <= 10)
                    {
                        priceWeight = 700;
                    }
                    else if (weight > 10)
                    {
                        priceWeight = 1000;
                    }
                    else if (price > 5000)
                    {
                        priceWeight = 0;
                    }
                    else if (weight < 0 || weight == 0)
                    {
                        Console.WriteLine("Ошибка, вес не может быть отрицательным");
                    }
                    break;
                case 3:
                    priceWeight = 0;
                    break;
            }
            switch (type)
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
            //Вывод данных
            Console.WriteLine("Товар: " + name);
            Console.WriteLine("Стоимость товара: " + price + " рублей");
            Console.WriteLine("Вес: " + weight + "кг");
            Console.WriteLine("Расстояние: " + distance + "м");
            Console.WriteLine("Способ доставки: " + tip);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Стоимость доставки: " + priceWeight);
            Console.WriteLine("Итоговая стоимость: " + (price + priceWeight));


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
            // НЕДОДЕЛАНО

        }
    }
}


