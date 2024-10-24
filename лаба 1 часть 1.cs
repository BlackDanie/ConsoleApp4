using System;

class Number
{
    // Закрытое поле для сбережения натурального числа
    private int value;

    // 1. Конструктор который присваивает полю его  значение
    public Number(int value)
    {
        this.value = value;
    }

    // 2. Метод проверяет число на натуральность
    public bool Correct()
    {
        return value > 0; // Число должно быть больше 0, чтобы быть натуральным
    }

    // 3. Метод проверяет число, простое оно или нет 
    public bool Prime()
    {
        if (value < 2) // Простое число должно быть больше или равно 2
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(value); i++)
        {
            if (value % i == 0)
            {
                return false; // Если число делится на i без остатка, оно не простое
            }
        }

        return true; // Если число не делится, то число простое
    }

    // 4. Метод проверяет является ли число палиндромом
    public bool Palindrome()
    {
        string strValue = value.ToString();
        char[] charArray = strValue.ToCharArray();
        Array.Reverse(charArray);
        string reversedValue = new string(charArray);

        return strValue == reversedValue; // Сравниваем число с его обратной версией
    }

    // 5. выводит значение числа
    public void Print()
    {
        Console.WriteLine("Число: " + value);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        Number number = new Number(userInput);

        //Метод проверяет число на натуральность
        if (number.Correct())
        {
            Console.WriteLine("Число является натуральным.");
        }
        else
        {
            Console.WriteLine("Число не является натуральным.");
        }

        // Метод проверяет число, простое оно или нет
        if (number.Prime())
        {
            Console.WriteLine("Число является простым.");
        }
        else
        {
            Console.WriteLine("Число не является простым.");
        }

        // Проверка, является ли число палиндромом
        if (number.Palindrome())
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }

        // Вывод числа
        number.Print();
    }
}
