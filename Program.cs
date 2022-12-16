class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 1: " + String.Join(", ", Ex1(new int[] { -1, 2, -3, 4 })));
        Console.WriteLine("Exercise 2: " + Ex2(2, new int[] { -11, 43, -42, 32 }));
        Console.WriteLine("Exercise 16: " + String.Join(", ", Ex16(new int[] { -1, 2, -3, 4 })));
        Console.WriteLine("Exercise 17: " + String.Join(", ", Ex17(new int[] { -18, -1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 32: " + String.Join(", ", Ex32(new string[] { "abc", "def", "gh" })));
        Console.WriteLine("Exercise 33: " + String.Join(", ", Ex33(new int[] { -18, -1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 44: " + String.Join(", ", Ex44(2, 3, new int[] { -5, -1, 1, -2, 2, 5, 4 }, new int[] { -4, -3, 2, 6 })));
        Console.WriteLine("Exercise 45: " + String.Join(", ", Ex45(5, 2, new string[] { "This", "is", "first", "array" }, new string[] {"So", "this", "is", "second", "array"})));
    }

    /* Дана целочисленная последовательность, содержащая как положительные,
    так и отрицательные числа. Вывести ее первый положительный элемент и
    последний отрицательный элемент.*/
    static int[] Ex1(int[] Input)
    {
        int[] result = new int[2];
        result[0] = Input.First(i => i > 0);
        result[1] = Input.Last(i => i < 0);
        return result;
    }

    /* Дана цифра D (однозначное целое число) и целочисленная
    последовательность A. Вывести первый положительный элемент
    последовательности A, оканчивающийся цифрой D. Если требуемых элементов
    в последовательности A нет, то вывести 0.*/
    static int Ex2(int D, int[] A) => A.FirstOrDefault(i => i >= 0 && i%10 == D,0);

    /* Дана целочисленная последовательность. Извлечь из нее все
    положительные числа, сохранив их исходный порядок следования.*/
    static int[] Ex16(int[] Input) => Input.Where(i => i >= 0).ToArray();

    /*Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
    сохранив их исходный порядок следования и удалив все вхождения
    повторяющихся элементов, кроме первых.*/
    static int[] Ex17(int[] Input) => Input.Where(i => i%2 != 0).Distinct().ToArray();

    /*Дана последовательность непустых строк A. Получить последовательность
    символов, каждый элемент которой является начальным символом
    соответствующей строки из A. Порядок символов должен быть обратным
    по отношению к порядку элементов исходной последовательности.*/
    static string[] Ex32(string[] a) => a.Select(i => i.First().ToString()).Reverse().ToArray();

    /*Дана целочисленная последовательность. Обрабатывая только положительные
    числа, получить последовательность их последних цифр и удалить в полученной
    последовательности все вхождения одинаковых цифр, кроме первого. Порядок
    полученных цифр должен соответствовать порядку исходных чисел.*/
    static int[] Ex33(int[] numbers) => numbers.Where(i => i >= 0).Select(i => i%10).Distinct().ToArray();

    /*Даны целые числа K1 и K2 и целочисленные последовательности A и B.
    Получить последовательность, содержащую все числа из A, большие K1,
    и все числа из B, меньшие K2. Отсортировать полученную последовательность
    по возрастанию.*/
    static int[] Ex44(int k1, int k2, int[] a, int[] b) => a.Where(i => i > k1).Concat(b.Where(i => i < k2)).OrderBy(i => i).ToArray();

    /*Даны целые числа K1 и K2 и целочисленные последовательности A и B.
Получить последовательность, содержащую все числа из A, большие K1,
и все числа из B, меньшие K2. Отсортировать полученную последовательность
по возрастанию.*/
    static string[] Ex45(int l1, int l2, string[] A, string[] B) => A.Where(i => i.Length == l1).Concat(B.Where(i => i.Length == l2)).OrderBy(i => i).ToArray();
}