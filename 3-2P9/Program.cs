using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2P9
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ломаные массивы
            int[] m1_1 = new int[2];
            int[] m1_2 = new int[] { 1, 2, 3 };
            int[,] m2_1 = new int[3, 2];
            int[,] m2_2 = new int[,] { 
                { 1, 2 }, 
                { 3, 4 } };
            int[][] ml2_1 = new int[2][];
            ml2_1[0] = new int[2];
            ml2_1[1] = new int[] { 2, 3, 3 };
            #endregion
            #region Вызов перегруженных методов
            Print(m1_1);
            Print(m1_2);
            Print(m2_1);
            Print(m2_2);
            Print(ml2_1);
            #endregion
            Console.ReadKey();

        }
        #region Перегрузка методов
        static void Print(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                Console.Write(m[i] + "\t");
            Console.WriteLine();
        }
        
        static void Print(int[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                    Console.Write(m[row, col] + "\t");
                Console.WriteLine();
            }
        }
        static void Print(int[][] m)
        {
            for (int row = 0; row < m.Length; row++)
                Print(m[row]);
        }
        #endregion
        #region Перечисление
        ///Примеры использования перечисления смотрите в тестах
        public enum turn { to_left =2, to_right=1, none=0 }
        public static string Turn(turn x)
        {
            string result = "";
            switch ((int)x)
            {
                case 2:
                    result += "НЛ";
                    break;
                case 1:
                    result += "НП";
                    break;
                case 0:
                    result += "ННД";
                    break;
                default:
                    break;
            }
            return result;
        }
        #endregion
    }
}
