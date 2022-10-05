using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8._1
{
    public class Function
    {
        /// <summary>
        /// Функция для заполнения списка n-го размера случайными ислами
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<int> Filling(int num)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            //Заполняем список
            for (int i = 0; i < num; i++)
            {
                list.Add(r.Next(0, 100));
            }
            return list;
        }

        /// <summary>
        /// Функция для вывода на экран нашего листа
        /// </summary>
        /// <param name="list1"></param>
        public void ShowData(List<int> list1)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < list1.Count; i++) Console.WriteLine($"{list1[i]} ");
            Console.WriteLine($"Число элеменов {list1.Count}");
        }

        /// <summary>
        /// Функция для удаления чисел из списка в заданном диапазоне
        /// </summary>
        /// <param name="list2"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public List<int> DelData(List<int> list2, int a, int b)
        {
            //Ищем все значения в списке согласно условию
            for (int i = 0; i < list2.Count; i++)
            {
                if (a < list2[i] & list2[i] < b)
                {
                    list2.RemoveAt(i); //Удаляем найденное значение
                    i--; //Переставляем индекс назадБ чтобы не допустыть пропуск
                }
            }
            return list2;
        }
    }
}

