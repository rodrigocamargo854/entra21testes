using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Arrays 
{
    public class ArraysListExercise6 
    {

        public List<double> Exercise6 (List<double> listA, List<double> listB)

        {
            var listC = new List<double> ();
            listA.Sort ();
            listB.Sort ();

            listB.Reverse ();

            for (int i = 0; i < listB.Count; i++) {

                listC.Add (listA[i] + listB[i]);
            }

            listC.Sort ();
            return listC;
        }

    }
}