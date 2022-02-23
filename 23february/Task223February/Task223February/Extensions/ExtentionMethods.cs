using System;
using System.Collections.Generic;
using System.Text;

namespace Task223February
{
    static class ExtentionMethods
    {
        public static bool IsEven(this int a)
        {
            if (a % 2 == 0)
            {
                return true;

            }
            return false;


        }
        public static bool IsOdd(this int a)
        {
            if (a % 2 != 0)
            {
                return true;

            }
            return false;

        }
        public static bool IsContainsDigit(this string reqemyoxlayam)
        {
            bool check = true;
            while (check)
            {

                bool checkDigit = false;
                foreach (char item in reqemyoxlayam)
                {
                    if (char.IsDigit(item))
                    {
                        checkDigit = true;
                        return true;

                    }
                    else return false;


                }
            }
            return true;

        }




         public static string[] GetValueIndexes(string[] arr, char a)
        {
            string[] final = new string[0];

            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == a)
                    {

                        Array.Resize(ref final, final.Length + 1);


                        final[final.Length - 1] = item;
                        break;
                    }

                }
            }

            return final;
        }



    }
}
