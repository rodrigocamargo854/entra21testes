

using System.Text;
using System;

namespace Exercise8_Arrays_List2 
{
    public class Exercise8_Arrays 
    {
        public int Exercise8 (string[] letters) 
        {
            string[] vogals = new string[5] { "a", "e", "i", "o", "u" };
            var countR = 0;

            foreach (var i in letters) 
            {
                foreach (var a in vogals) 
                {
                    if (i == a)
                    {
                        countR++;
                    }

                }

            }
                            return countR;

        }
    }
}