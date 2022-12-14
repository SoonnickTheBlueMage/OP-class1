namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 | i == height - 1 | j == 0 | j == width - 1)
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            while (i < height)
            {
                int j = 0;
                while (j < width)
                {
                    if (i == 0 | i == height - 1 | j == 0 | j == width - 1)
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            long x = a;
            long y = b;
            long z;
            while (y != 0)
            {
                z = x;
                x = y;
                y = z % y;
            }

            return x;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double s = 1 + x;
            double fact = 1;
            double xPov = x;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
                xPov *= x;
                s += (xPov / fact);
            }

            return s;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(3, 5, '-');
            Console.WriteLine(Gcd(198, 44));
            Console.WriteLine(ExpTaylor(2, 100));
        }
    }
}