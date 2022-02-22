using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateTests
{
    class GenerateRandomData
    {
        public static string GenerateRandomEnString(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(65, 91);
                data += (char)array[i];
            }

            return data.ToLower();
        }

        public static string GenerateRandomNumber(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(48, 58);
                data += (char)array[i];
            }

            return data.ToLower();
        }

        public static string GenerateRandomUaString(int size)
        {
            char[] chars = "АБВГҐДЕЄЖЗИІЇКЛМНОПРСТУФХЦЧШЩЬЮЯ".ToCharArray();
            char[] array = new char[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = chars[random.Next(0, chars.Length)];
                data += array[i];
            }

            return data;
        }
    }
}
