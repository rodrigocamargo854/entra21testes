using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Arrays_List2 
{
    public class Exercicio3_Arrays 
    {
        public int PeopleAnsweredYes (double man, double woman) => (int) (man + woman);

        public int PeopleAnsweredNo (double manAnsweredNo, double womanAnsweredNo) => (int) (manAnsweredNo + womanAnsweredNo);

        public double PercentageOfWomenAnsweredYes (double womenAnsweredYes, int women) => Math.Round ((womenAnsweredYes / women) * 100, 2);

        public double PercentageOfMenAnsweredNo (double menAnsweredNo, int men) => Math.Round ((menAnsweredNo / men) * 100, 2);
    }
}