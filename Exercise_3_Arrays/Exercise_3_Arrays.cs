
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Exercise_3_Arrays 
{
    public class Exercise_3_Arrays 
    {
        public bool Exercise3 ( List<double> num, double digit) 
        {
            return num.Exists (x => x.Equals (digit));
        }

    }
}