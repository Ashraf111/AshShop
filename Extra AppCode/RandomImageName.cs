using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AshShop.Extra_AppCode
{
    public class RandomImageName
    {
        public static string GetRandomImageName(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string imageName = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //For avoiding Repetation of Characters
                if (!imageName.Contains(chars.GetValue(x).ToString()))
                    imageName += chars.GetValue(x);
                else
                    i = i - 1;
            }
            return imageName;
        }
    }
}