using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_Arrays_List2 
{
    public class Exercise6_Arrays 
    {
        public (double, double) Exercicio6 ( List<double> list) 
        {
            var onlyPositives = new List<double> ();
            double indexBiggest = 0;

            for (int i = 0; i < list.Count; i++)

            {
                if (list[i] > 0) 
                {
                    onlyPositives.Add (list[i]);
                
                }

                

            }

            return (onlyPositives.Max(), indexBiggest);

        }

    }
}