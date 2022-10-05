//Petrova E.
//Задача. Напишите программу, которая из имеющегося массива срок формирует массив из строк, длина которых меньше либо равна 3 символа.

namespace CSHProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string dStrArr;
            int index = 0;
            Console.WriteLine("Введите значения через запятую для преобразования в массив строк: ");
            dStrArr = Console.ReadLine();
            string[] dParseArr = new string[dStrArr.Length];
            for (int i = 0; i < dStrArr.Length; i++)
            {
                if ((dStrArr[i] != ','))
                {
                    dParseArr[index] = dParseArr[index] + dStrArr[i].ToString();
                }
                else
                {
                    index++;
                }
            }
            Console.Write("Веденный Вами массив: [ '");
            for (int j = 0; j <= index; j++)
            {
                if (j <= index - 1)
                {
                    if (string.IsNullOrEmpty(dParseArr[j])) { dParseArr[j] = " "; }
                    Console.Write(dParseArr[j] + "', '");
                }
                else
                {
                    Console.Write(dParseArr[j] + "' ]");
                }
            }
            Console.WriteLine("");
            //Создаем и заполняем массив для элементов длиной меньше либо равно 3.;
            string[] d3ParseArr = new string[index];
            int cnt3d = 0;
            for (int j = 0; j <= index; j++)
            {
                if (dParseArr[j].Length < 4)
                {
                    d3ParseArr[cnt3d] = dParseArr[j];
                    cnt3d++;
                }
            }
            Console.WriteLine("");
            //Выводим массив для элементов длиной меньше либо равно 3.
            if (cnt3d > 0)
            {
                Console.Write("Элементы с длиной меньше либо равно 3: [ '");
                for (int j = 0; j < cnt3d; j++)
                {
                    if (j < cnt3d - 1)
                    {
                        Console.Write(d3ParseArr[j] + "', '");
                    }
                    else
                    {
                        Console.Write(d3ParseArr[j] + "' ]");
                    }
                }
                Console.WriteLine("");
            }
            else { Console.Write("Элементы с длиной меньше либо равно 3 отсутствуют.");}
        }
    }
}