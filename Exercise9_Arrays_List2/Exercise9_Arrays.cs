using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9_Arrays_List2 
{
    public class Exercise9_Arrays
     {
        public string Exercise9 (string[] letters) 
        {

            var msg = "";

            for (int i = 0; i < letters.Length; i++) 
            {
                msg = i % 2 == 0? msg+=letters[i] : msg;

            }

            return msg;

        }

    }
}