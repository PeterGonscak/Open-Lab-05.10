using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int total = 1;
            char[] a = num.ToString().ToCharArray();
            foreach (char item in a)
            {
                int b;
                int.TryParse(item.ToString(),out b);
                total *= b;
            }
            return total;
        }
    }
}
