using System;
using System.Linq;

namespace ClassLibrary3
{
    public class StringCalculator
    {
        public StringCalculator() { }
        public int Add(string str) 
        {
            int sum = 0;
            if (str == string.Empty) return sum;
            if (str.StartsWith("//")) 
            {
                str.Remove(0, 2);
                int i = str.IndexOf('[');
                int j = str.IndexOf(']');
                if (i == -1 || j == -1) str.Remove(0, 1);
                else 
                {
                    while (i != -1 && j != -1)
                    {
                        if (i >= j) break;
                        str.Remove(0, j + 2);
                        i = str.IndexOf('[');
                        j = str.IndexOf(']');
                    }
                }
               
            }
            string[] parsed = str.Split(new char[] { ',', '\n' }, StringSplitOptions.None);
            foreach(string num in parsed) 
            {
                if(int.TryParse(num,out int res)) 
                {
                    sum += res >= 0 ? (res > 1000 ? 0 : res) : throw new ArgumentException("number is negative");
                }
            }
            return sum;
        }
    }
}
