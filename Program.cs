class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 1: " + String.Join(", ", Ex1(new int[] { -1, 2, -3, 4 })));
        Console.WriteLine("Exercise 2: " + Ex2(2, new int[] { -11, 43, -42, 32 }));
        Console.WriteLine("Exercise 3: " + Ex3(4, new string[] { "1. Дана цілочисленна послідовність",
                                                                "2. Дана цифра D",
                                                                "3. Дано ціле число L (> 0) та строкова послідовність A",
                                                                "4. Дан символ С и строковая последовательность A",
                                                                "4. M",
                                                                "4. I",
                                                                "5. Дано символ С та строкова послідовність A" }));
        Console.WriteLine("Exercise 4: " + Ex4('C', new string[] { "Once meeted persons of Frankivsk, Kyiv, Kherson and Kharkiv",
                                                                "Kyiv: I love programming on Java",
                                                                "Kherson: I love programming on C#",
                                                                "Frankivs: I'm so strange, I write a code in a notebook and programming on C++",
                                                                "Kharkiv: I'm a freak. I love tomato juice and programming on C",}));
        Console.WriteLine("Exercise 5: " + Ex5('C', new string[] { "C++ or C",
                                                                "C or C++",
                                                                "C# or C"}));
        Console.WriteLine("Exercise 16: " + String.Join(", ", Ex16(new int[] { -1, 2, -3, 4 })));
        Console.WriteLine("Exercise 17: " + String.Join(", ", Ex17(new int[] { -18, -15, -2, -1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 18: " + String.Join(", ", Ex18(new int[] { -18, -15, -2, -1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 19: " + String.Join(", ", Ex19(1 , new int[] { -181, -15, -2, -1, 0, 1, 4, 171, 1 })));
        Console.WriteLine("Exercise 32: " + String.Join(", ", Ex32(new string[] { "abc", "def", "gh" })));
        Console.WriteLine("Exercise 33: " + String.Join(", ", Ex33(new int[] { -18, -1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 34: " + String.Join(", ", Ex34(new int[] { 18, 1, 0, 1, 4, 17, 1 })));
        Console.WriteLine("Exercise 36: " + String.Join(", ", Ex36(new string[] { "Once meeted persons of Frankivsk, Kyiv, Kherson and Kharkiv",
                                                                "Kyiv: I love programming on Java",
                                                                "Kherson: I love programming on C#",
                                                                "Frankivs: I'm so strange, I write a code in a notebook and programming on C++",
                                                                "Kharkiv: I'm a freak. I love tomato juice and programming on C",})));
        Console.WriteLine("Exercise 44: " + String.Join(", ", Ex44(2, 3, new int[] { -5, -1, 1, -2, 2, 5, 4 }, new int[] { -4, -3, 2, 6 })));
        Console.WriteLine("Exercise 45: " + String.Join(", ", Ex45(5, 2, new string[] { "This", "is", "first", "array" }, new string[] {"So", "this", "is", "second", "array"})));
        Console.WriteLine("Exercise 60: " + String.Join(", ", Ex60(new string[] { "LA", "LA", "LA", "WAY", "LA", "LA", "LA", "WAY", "LA", "LA", "LA", "HEY", "LA", "LA", "LA", "HEY" })));
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

    /*Дано целое число L (> 0) и строковая последовательность A. Вывести
    последнюю строку из A, начинающуюся с цифры и имеющую длину L. Если
    ребуемых строк в последовательности A нет, то вывести строку «Not found».*/
    static string Ex3(int L, string[] A) => A.LastOrDefault(i => i.First().ToString() == L.ToString() && i.Length == L, "Not found");

    /*Дан символ С и строковая последовательность A.
    Если A содержит единственный элемент, оканчивающийся символом C, то вывести этот элемент;
    если требуемых строк в A нет, то вывести пустую строку;
    если требуемых строк больше одной, то вывести строку «Error».*/
    static string Ex4(char C, string[] A)
    {
        try
        {
            return A.SingleOrDefault(i => i.Last() == C, "");
        }
        catch (System.Exception)
        {
            return "Error";
        }
    }

    /*Дан символ С и строковая последовательность A. Найти
    количество элементов A, которые содержат более одного символа и при этом
    начинаются и оканчиваются символом C.*/
    static int Ex5(char C, string[] A) => A.Where(i => i.Length > 1 && i.First() == C && i.Last() == C).Count();

    /* Дана целочисленная последовательность. Извлечь из нее все
    положительные числа, сохранив их исходный порядок следования.*/
    static int[] Ex16(int[] Input) => Input.Where(i => i >= 0).ToArray();

    /*Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
    сохранив их исходный порядок следования и удалив все вхождения
    повторяющихся элементов, кроме первых.*/
    static int[] Ex17(int[] Input) => Input.Where(i => i%2 != 0).Distinct().ToArray();

    /*Дана целочисленная последовательность. Извлечь из нее все четные
    отрицательные числа, поменяв порядок извлеченных чисел на обратный.*/
    static int[] Ex18(int[] Input) => Input.Where(i => i < 0 && i % 2 == 0).Reverse().ToArray();

    /*Дана цифра D (целое однозначное число) и целочисленная последовательность A.
    Извлечь из A все различные положительные числа, оканчивающиеся цифрой D
    (в исходном порядке). При наличии повторяющихся элементов удалять все их вхождения,
    кроме последних.*/
    static int[] Ex19(int D, int[] A) => A.Where(i => i > 0 && i%10 == D).Distinct().ToArray();

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

    /*Дана последовательность положительных целых чисел. Обрабатывая только
    нечетные числа, получить последовательность их строковых представлений и
    отсортировать ее в лексикографическом порядке по возрастанию.*/
    static string[] Ex34(int[] numbers) => numbers.Where(i => i%2 != 0).Select(i => i.ToString()).OrderDescending().ToArray();

    /*Дана последовательность непустых строк. Получить последовательность символов,
    которая определяется следующим образом: если соответствующая строка
    исходной последовательности имеет нечетную длину, то в качестве символа
    берется первый символ этой строки; в противном случае берется последний символ строки.
    Отсортировать полученные символы по убыванию их кодов.*/
    static char[] Ex36(string[] str) => str.Select(i => i.Length % 2 == 0 ? i.Last() : i.First()).Order().ToArray();

    /*Даны целые числа K1 и K2 и целочисленные последовательности A и B.
    Получить последовательность, содержащую все числа из A, большие K1,
    и все числа из B, меньшие K2. Отсортировать полученную последовательность
    по возрастанию.*/
    static int[] Ex44(int k1, int k2, int[] a, int[] b) => a.Where(i => i > k1).Concat(b.Where(i => i < k2)).Order().ToArray();

    /*Даны целые числа K1 и K2 и целочисленные последовательности A и B.
Получить последовательность, содержащую все числа из A, большие K1,
и все числа из B, меньшие K2. Отсортировать полученную последовательность
по возрастанию.*/
    static string[] Ex45(int l1, int l2, string[] A, string[] B) => A.Where(i => i.Length == l1).Concat(B.Where(i => i.Length == l2)).Order().ToArray();

    /*Даны последовательности положительных целых чисел A и B; все числа
    в каждой последовательности различны. Найти последовательность всех пар чисел,
    удовлетворяющих следующим условиям: первый элемент пары принадлежит
    последовательности A, второй принадлежит B, и оба элемента оканчиваются
    одной и той же цифрой. Результирующая последовательность называется
    внутренним объединением последовательностей A и B по ключу,
    определяемому последними цифрами исходных чисел.
    Представить найденное объединение в виде последовательности строк,
    содержащих первый и второй элементы пары, разделенные дефисом, например,
    «49-129». Порядок следования пар должен определяться
    исходным порядком элементов последовательности A,
    а для равных первых элементов — порядком элементов последовательности B.*/
    //static string[] Ex46(int[] A, int[] B) =>

    /*Дана последовательность непустых строк A, содержащих
    только заглавные буквы латинского алфавита. Для всех строк,
    начинающихся с одной и той же буквы, определить их суммарную длину
    и получить последовательность строк вида «S-C», где S — суммарная длина всех строк
    из A, которые начинаются с буквы С. Полученную последовательность упорядочить
    по убыванию числовых значений сумм,
    а при равных значениях сумм — по возрастанию кодов символов C.*/
    static string[] Ex60(string[] str) => str.Select(i => new {chr = i.First(), Count = str.Sum(j => j.First() == i.First() ? j.Length : 0)}).Distinct().OrderBy(i => i.chr).OrderByDescending(i => i.Count).Select(i => i.Count.ToString() + "-" + i.chr.ToString()).ToArray();
}