

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Exercise3_Arrays_List2
{
    public class Exercise2_Arrays
    {
         public bool Exercise2 ( List<double> listA)

        {

            for (int i = 0; i < listA.Count-1; i++)

            {
               if(listA[i] == listA[i+1])
               {
                   return true;
               }

            }

            return false;
        }
    }
}