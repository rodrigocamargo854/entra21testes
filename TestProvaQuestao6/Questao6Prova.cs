using System;
using System.Collections.Generic;
using System.Text;

namespace TestProvaQuestao6 {
    public class Questao6Prova {

        public double Questao6 (params double[] salary)

        {
            double acum = 0.0;
            double media = 0.0;
            double count = 1;

            for (int i = 0; i < salary.Length; i++)

            {

                if (salary[i] < 0) 
                {
                    count--;
                }
                
                 else
                {
                    acum += salary[i];
                    count++;

                }

            }

            media = (acum / count);

            return Math.Round (media, 2);
        }

    }
}