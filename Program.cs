namespace GeekBrains
{
    public class Task_1
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int n = InputNumbers("Введите размер массива M: ");
            string?[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите значение массива: ");
                array[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Изначальный массив: [" + string.Join(", ", array) + "]");

            string?[] array2 = new string[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                     {
                        array2[count] = array[i];
                        count++;
                    }      
                }
            Array.Resize(ref array2, count);
            Console.WriteLine();
            if (array2.Length > 0)
                Console.WriteLine($"Итоговый массив: [" + string.Join(", ", array2) + "]");
            else
                Console.WriteLine("Все значения массива больше 3 символов!");

        }
        public static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}