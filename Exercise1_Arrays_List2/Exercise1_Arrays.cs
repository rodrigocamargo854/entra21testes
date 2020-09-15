using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Arrays_List2

{
    public class Exercise1_Arrays 
    {

        public (List<double>, List<double>) Exercise1 (List<double> listA, List<double> listB)

        {
            var listC = new List<double> ();

            for (int i = 0; i < listB.Count; i++)

            {
                listC[i] = listA[i];
                listA[i] = listB[i];
                listB[i] = listC[i];

            }

            return (listA, listB);
        }

    }

}