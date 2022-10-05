using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_8._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Function fun = new Function();
        List<int> newList = new List<int>();

        //Заполняем наш список
        newList = fun.Filling(100);

        //Выводим список в консоль
        fun.ShowData(newList);
        Console.ReadKey();

        //Удаляем значения из списка в указанном диапазоне
        fun.DelData(newList, 25, 50);

        //Выводим список после преобразования в консоль
        fun.ShowData(newList);
        Console.ReadKey();

        //Очищаем консоль
        Console.Clear(); 

    }
}